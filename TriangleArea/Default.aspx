<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TriangleArea._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
    <div class="row">
       
        
    </div>
    <br>
    <br>
    <img src="../image/triangle.png" />
    <script type="text/javascript" src="../Scripts/indexT.js"></script>
    <div id="test" onclick="alert('stop')">
        <button id='butYellow' onclick='event.stopPropagation()'>butYellow</button>
    </div>

    <br>

    <table>
        <tr>
            <th>катет (a) </th>
            <th>
                <input value="0" name="aCathetus" /></th>
        </tr>
        <tr>
            <th>катет (b) </th>
            <th>
                <input value="0" name="bCathetus" /></th>
        </tr>
        <tr>
            <th>гипотенуза (c) </th>
            <th>
                <input value="0" name="hipotenuse" /></th>
        </tr>
    </table>
    <br>
    <div title="green" class="tributton">
        <button class="button buttonkol_size" type="submit"><b>Посчитать</b></button>
    </div>
    <div class="green blue" data-price="40">cathetus</div>
    <div class="green blue" data-kol="Stop">hypotenuse</div>
    <ul onclick="console.log('--02')">
        <li onclick="console.log('--01')">cathetus
            <ul>
                <li>cathetus
                    <ul>
                        <li>hypotenuse</li>

                    </ul>
                </li>
            </ul>
        </li>
        
        
    </ul>
    <ul onclick="console.log('--02')">
        <li onclick="console.log('--01')">cathetus
            <ul>
                <li>cathetus
                    <ul>
                        <li>hypotenuse</li>

                    </ul>
                </li>
            </ul>
        </li>
        
        
    </ul>
    <button id="CreateReport">Create Report</button>
    
    <br>
    <br>
    <a href="/HomeWebForm">sort link</a>
    <a href="#" class="google"></a>
    <a href="#" class="youtube"></a>
    <input list="country" />
    <datalist id="country">
        <option value="triangle"></option>
        <option value="quad"></option>
    </datalist>
    <img align="center" src="../image/block.jpg" loading="lazy" width="100" alt="..." />
    <asp:PlaceHolder ID="PlaceHolder1"
        runat="server" />


</asp:Content>




