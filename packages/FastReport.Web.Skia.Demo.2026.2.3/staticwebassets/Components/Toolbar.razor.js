'use strict;'
class Searcher {
    static ToolbarDotNet;
    static NotFoundText = "Not found";
    static ScrollOffsetTop = 0;

    static setSearcherProps(toolbarDotNet, notFoundText, scrollOffsetTop) {
        Searcher.ToolbarDotNet = toolbarDotNet;
        Searcher.NotFoundText = notFoundText;
        Searcher.ScrollOffsetTop = scrollOffsetTop;
    }

    static resetIndex() {
        sessionStorage.setItem('fastreport-search-text', '');
    };

    static toggleSearchForm() {
        const form = document.getElementById('fr-toolbar-search-form');
        const searchText = sessionStorage.getItem('fastreport-search-text');
        const matchCase = sessionStorage.getItem('fastreport-search-match-case') === 'true';
        const wholeWord = sessionStorage.getItem('fastreport-search-whole-word') === 'true';
        form.classList.toggle('open');

        if (form.classList.contains('open')) {
            this.findNext(
                sessionStorage.getItem('fastreport-search-index'),
                searchText,
                matchCase,
                wholeWord,
                false
            );
        }
        else {
            this.findNext(
                0,
                searchText,
                matchCase,
                wholeWord,
                true
            );
        }
    };

    static getSearchRanges(text, matchCase, wholeWord, container) {
        const curScrollY = window.scrollY;
        const curScrollX = window.scrollX;
        const sel = globalThis.getSelection();
        const ranges = [];
        // find all occurrences in a page
        while (globalThis.find(text, matchCase, false, false, wholeWord, false, false)) {
            // filter out search results outside of a specific element
            if (container.contains(sel.anchorNode)) {
                ranges.push(sel.getRangeAt(sel.rangeCount - 1));
            }
        }
        window.scrollTo(curScrollX, curScrollY);
        return ranges;
    };

    static findNext(index, text, matchCase, wholeWord, removeHighlight) {
        const container = Searcher._findContainer();
        const sel = globalThis.getSelection();

        sel.collapse(container, 0);
        let ranges = Searcher.getSearchRanges(text, matchCase, wholeWord, container);
        sel.collapse(container, 0);

        if (ranges.length === 0) return false;

        const targetRanges = Searcher._getTargetRanges(ranges, index, removeHighlight);
        if (targetRanges.length === 0) return false;

        const range = targetRanges[0];
        Searcher._processRange(range, removeHighlight);

        return true;
    }

    static _getTargetRanges(ranges, index, removeHighlight) {
        if (removeHighlight) {
            return ranges.filter(r => r.startContainer.parentElement.classList.contains('search-highlight'));
        }

        if (index >= 0 && index < ranges.length) {
            const sortedRanges = [...ranges].sort((a, b) => {
                return a.startContainer.parentElement.getBoundingClientRect().top -
                    b.startContainer.parentElement.getBoundingClientRect().top;
            });
            return [sortedRanges[index]];
        }

        return [];
    }

    static _processRange(range, removeHighlight) {
        if (range.startContainer === range.endContainer) {
            Searcher._applyHighlight(range, removeHighlight);
            return;
        }

        const textNodes = Searcher.getTextNodesInRange(
            range.commonAncestorContainer,
            range.startContainer,
            range.endContainer
        );

        const startOffset = range.startOffset;
        const endOffset = range.endOffset;

        for (let j = 0; j < textNodes.length; j++) {
            const node = textNodes[j];
            const isFirst = j === 0;
            const isLast = j === textNodes.length - 1;

            range.setStart(node, isFirst ? startOffset : 0);
            range.setEnd(node, isLast ? endOffset : node.nodeValue.length);

            Searcher._applyHighlight(range, removeHighlight);
        }
    }

    static _applyHighlight(range, removeHighlight) {
        if (removeHighlight) {
            Searcher.clearHighlight(range);
        } else {
            Searcher.highlight(range);
        }
    }

    static search(backward) {
        const searchText = document.getElementById('fr-search-text').value;
        const lastSearchText = sessionStorage.getItem('fastreport-search-text');
        let index = Searcher._getStoredIndex();
        const matchCase = document.getElementById(`fr-match-case`).checked;
        const wholeWord = document.getElementById(`fr-whole-word`).checked;
        document.getElementById(`fr-searchform-text-info`).innerText = ``;

        Searcher._clearPreviousHighlights(lastSearchText);

        index = Searcher._calculateNewIndex(index, backward, lastSearchText, searchText);

        if (!Searcher.findNext(index, searchText, matchCase, wholeWord, false)) {
            Searcher._handleNotFound(searchText, backward, matchCase, wholeWord, index);
        }

        Searcher._storeSearchState(index, searchText, matchCase, wholeWord);
    }

    static _getStoredIndex() {
        const index = sessionStorage.getItem('fastreport-search-index');
        return index ? Number.parseInt(index) : -1;
    }

    static _clearPreviousHighlights(lastSearchText) {
        if (lastSearchText) {
            Searcher.findNext(
                -1,
                lastSearchText,
                sessionStorage.getItem('fastreport-search-match-case') === 'true',
                sessionStorage.getItem('fastreport-search-whole-word') === 'true',
                true
            );
        }
    }

    static _calculateNewIndex(currentIndex, backward, lastSearchText, searchText) {
        let newIndex = currentIndex;

        if (backward) {
            newIndex--;
        } else {
            newIndex++;
        }

        if (lastSearchText !== searchText) {
            newIndex = 0;
        }

        return newIndex;
    }

    static _handleNotFound(searchText, backward, matchCase, wholeWord, currentIndex) {
        const container = Searcher._findContainer();

        Searcher.ToolbarDotNet.invokeMethodAsync('SearchText', searchText, backward, matchCase, wholeWord)
            .then((found) => {
                if (found) {
                    const ranges = Searcher.getSearchRanges(searchText, matchCase, wholeWord, container);
                    const newIndex = backward ? ranges.length - 1 : 0;
                    sessionStorage.setItem('fastreport-search-index', newIndex);

                    if (!Searcher.findNext(newIndex, searchText, matchCase, wholeWord, false)) {
                        document.getElementById('fr-searchform-text-info').innerText = Searcher.NotFoundText;
                    }
                } else {
                    const fallbackIndex = backward ? 0 : currentIndex - 1;
                    Searcher.findNext(fallbackIndex, searchText, matchCase, wholeWord, false);
                    sessionStorage.setItem('fastreport-search-index', fallbackIndex);
                    document.getElementById('fr-searchform-text-info').innerText = Searcher.NotFoundText;
                }
            });
    }

    static _storeSearchState(index, searchText, matchCase, wholeWord) {
        sessionStorage.setItem('fastreport-search-index', index);
        sessionStorage.setItem('fastreport-search-text', searchText);
        sessionStorage.setItem('fastreport-search-match-case', matchCase);
        sessionStorage.setItem('fastreport-search-whole-word', wholeWord);
    }

    static _findContainer() {
        return document.getElementsByClassName('fr-report-body')[0];
    };

    static highlight(range) {
        const newNode = document.createElement('span');
        newNode.className = 'search-highlight';
        range.surroundContents(newNode);
        const rect = newNode.getBoundingClientRect();
        const vWidth = (window.innerWidth || document.documentElement.clientWidth) - rect.width;
        const vHeight = (window.innerHeight || document.documentElement.clientHeight) - rect.height;
        let topOfElement = window.scrollY;
        let leftOfElement = window.screenX;

        if (rect.bottom < rect.height || rect.top > vHeight)
            topOfElement = topOfElement + rect.top - Searcher.ScrollOffsetTop;
        if (rect.right < rect.width || rect.left > vWidth)
            leftOfElement = leftOfElement + rect.left;
        window.scroll({ top: topOfElement, left: leftOfElement, behavior: 'smooth' });
    };

    static clearHighlight(range) {
        const selection = document.getSelection()
        selection.removeAllRanges()
        selection.addRange(range)
        const selParent = selection.anchorNode?.parentElement;
        const selectedElem = selParent?.nodeType == 1 && selParent?.children.length < 2 && selParent;
        if (selectedElem.tagName === 'SPAN' && selectedElem.classList.contains('search-highlight')) {
            selectedElem.previousSibling.nodeValue += selectedElem.innerText;
            selectedElem.previousSibling.nodeValue += selectedElem.nextSibling.nodeValue;
            selectedElem.nextSibling.remove();
            selectedElem.remove();
        }
    };

    static getTextNodesInRange(rootNode, firstNode, lastNode) {
        const nodes = []
        let startNode = null, endNode = lastNode
        const walker = document.createTreeWalker(
            rootNode,
            // search for text nodes
            NodeFilter.SHOW_TEXT,
            // Logic to determine whether to accept, reject or skip node.
            // In Searcher case, only accept nodes that are between
            // <code>firstNode</code> and <code>lastNode</code>
            {
                acceptNode: function (node) {
                    if (!startNode) {
                        if (firstNode == node) {
                            startNode = node
                            return NodeFilter.FILTER_ACCEPT
                        }
                        return NodeFilter.FILTER_REJECT
                    }

                    if (endNode) {
                        if (lastNode == node) {
                            endNode = null
                        }
                        return NodeFilter.FILTER_ACCEPT
                    }

                    return NodeFilter.FILTER_REJECT
                }
            },
            false
        )

        while (walker.nextNode()) {
            nodes.push(walker.currentNode)
        }
        return nodes
    }
}

function addHandlers() {
    const searchPrev = document.getElementById("fr-search-prev");
    searchPrev.addEventListener("click", function () { Searcher.search(true) });

    const searchNext = document.getElementById("fr-search-next");
    searchNext.addEventListener("click", function () { Searcher.search(false) });
}
export { Searcher, addHandlers };
