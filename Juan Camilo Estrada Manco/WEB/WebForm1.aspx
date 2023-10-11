<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebExamenTour.webExamen.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="nav-justified" style="width: 94%">
            <tr>
                <td class="text-center" colspan="2" style="font-size: xx-large; color: #FF3399"><strong>TOURES EL MANCO</strong></td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 653px; height: 34px"><strong>TIPO DE TOUR:</strong></td>
                <td class="text-center" style="height: 34px">
                    <asp:DropDownList ID="ddlTour" runat="server">
                        <asp:ListItem>Ciudad amurallada y Castillo San Felipe</asp:ListItem>
                        <asp:ListItem>Playas</asp:ListItem>
                        <asp:ListItem>Isla Barú</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 653px">&nbsp;<span style="font-size: x-large"><strong>NUMERO PERSONAS:</strong></span></td>
                <td class="text-center">
                    <asp:TextBox ID="txtNpersonas" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 653px"><strong>¿ALMUERZO INCLUIDO?</strong></td>
                <td class="text-center">
                    <asp:CheckBox ID="CheckAlmuerzo" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="text-right"><strong>
                    <asp:Button ID="btnCalcularValor" runat="server" BackColor="#3399FF" BorderColor="Yellow" BorderStyle="Outset" Height="44px" OnClick="btnCalcularValor_Click" Text="CALCULAR" Width="213px" />
                    </strong></td>
                <td>
                    <asp:Button ID="btnLimpiar" runat="server" BackColor="#66FF66" BorderColor="#66FF99" BorderStyle="Outset" Height="42px" OnClick="btnLimpiar_Click" Text="LIMPIAR" Width="203px" />
                </td>
            </tr>
            <tr>
                <td style="width: 653px; height: 20px">
                    <asp:Label ID="txtError" runat="server" style="color: #CC0000"></asp:Label>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 653px; height: 34px"><strong>VALOR SIN DESCUENTO:</strong></td>
                <td class="text-center" style="height: 34px">
                    <asp:Label ID="txtValorSinDescuento" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 653px"><strong>DESCUENTO:</strong></td>
                <td class="text-center">
                    <asp:Label ID="txtDescuento" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 653px; height: 34px"><strong>VALOR PAGAR:</strong></td>
                <td class="text-center" style="height: 34px">
                    <asp:Label ID="txtValorPagar" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 653px"><strong>VALOR ANTES IVA:</strong></td>
                <td class="text-center">
                    <asp:Label ID="txtValorAntesIva" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 653px"><strong>VALOR IVA:</strong></td>
                <td class="text-center">
                    <asp:Label ID="txtValorIva" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                </td>
            </tr>
        </table>
        &nbsp;</p>
</asp:Content>
