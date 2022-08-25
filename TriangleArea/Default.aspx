<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TriangleArea._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        
    <div class="row">
       
        
    </div>
    <br>
    <br>
    <img src="../image/triangle.png" />
    <script type="text/javascript" src="../Scripts/indexT.js"></script>
    <div id="test" onclick="alert('stop')">
        <button id='but0000' onclick='event.stopPropagation()'>but0000</button>
    </div>
    <br>

    <table>
        <tr>
            <th>катет (a) </th>
            <th>
                <input value="0" name="aCathetus" /></th>
            <br>
        </tr>
        <tr>
            <th>катет (b) </th>
            <th>
                <input value="0" name="bCathetus" /></th>
            <br>
        </tr>
        <tr>
            <th>гипотенуза (c) </th>
            <th>
                <input value="0" name="hipotenuse" /></th>
        </tr>
    </table>
    <br>
    <button type="submit"><b>Подсчитать</b></button>


    <asp:PlaceHolder ID="PlaceHolder1"
        runat="server" />


</asp:Content>




