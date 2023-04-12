<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Patrones.Command.UI3.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!--<div style="text-align: center">
            <asp:Label runat="server" Text="Modelo:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtModelo3" runat="server" ToolTip="Representa el modelo de la computadora"></asp:TextBox>
        </div>
    <div style="text-align: center">
            <asp:Label runat="server" Text="Procesador:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtProcesador3" runat="server" ToolTip="Representa el procesador de la computadora"></asp:TextBox>
        </div>
    <div style="text-align: center">
            <asp:Label runat="server" Text="Memoria RAM:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtRam" runat="server" ToolTip="Representa la memora RAM de la computadora"></asp:TextBox>
        </div>
    <div style="text-align: center">
            <asp:Label runat="server" Text="Almacenamiento:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtDisco" runat="server" ToolTip="Representa el almacenamiento de la computadora"></asp:TextBox>
        </div>
   
    <div style="text-align: center">
    <button type="button" OnClick="btnAddComputer_Click">Agregar Computadora</button>
    </div>

<asp:GridView ID="gridComputers" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
        <asp:BoundField DataField="Procesador" HeaderText="Procesador" />
        <asp:BoundField DataField="RAM" HeaderText="RAM" />
        <asp:BoundField DataField="Almacenamiento" HeaderText="Almacenamiento" />
    </Columns>
</asp:GridView>

    <div style="text-align: center">
<button type="button" onclick="clonarComputadoras()">Clonar Computadoras</button>
        </div>-->
        <h1 runat="server">Add Computer</h1>
        <table runat="server">
            <tr runat="server">
                <td>Modelo:</td>
                <td><asp:TextBox ID="txtModelo" runat="server" Width="450px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Procesador:</td>
                <td><asp:TextBox ID="txtProcesadors" runat="server" Width="450px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Memoria:</td>
                <td><asp:TextBox ID="txtMemoria" runat="server" Width="450px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Almacenamiento:</td>
                <td><asp:TextBox ID="txtAlmacenamiento" runat="server" Width="450px"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click" /></td>
            </tr>
        </table>
        <hr />
        <asp:Label ID="lblMensaje" runat="server" Font-Size="Small" ></asp:Label>
        <h1>Computers</h1>
        <table>
            <tr>
                <th>Modelo</th>
                <th>Procesador</th>
                <th>Memory</th>
                <th>Almacenamiento</th>
                <th></th>
            </tr>
            <asp:Repeater ID="ComputersRepeater" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Modelo") %></td>
                        <td><%# Eval("Procesador") %></td>
                        <td><%# Eval("Memory") %></td>
                        <td><%# Eval("Almacenamiento") %> GB</td>
                        <td><asp:Button ID="CloneButton" runat="server" Text="Clone" CommandName="Clone" CommandArgument='<%# Container.ItemIndex %>' OnCommand="CloneButton_Command" /></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
             </table>

</asp:Content>
