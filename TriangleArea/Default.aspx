﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TriangleArea._Default" %>

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
    <button class="button buttonkol_size" type="submit"><b>Подсчитать</b></button>
    <div class="green blue">cathetus</div>
    <div class="green blue">hypotenuse</div>
<<<<<<< HEAD
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
        
        
=======
    <ul class="ulkol">
        <li class="likol">cathetus</li>
        <li class="likol">cathetus</li>
        <li class="likol">hypotenuse</li>
>>>>>>> parent of 11f7690 (add click)
    </ul>
    <a href="/HomeWebForm">sort link</a>


    <asp:PlaceHolder ID="PlaceHolder1"
        runat="server" />


</asp:Content>




