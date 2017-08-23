<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfFinanciamento.aspx.cs" Inherits="Controliti.Modulo.Financeiro.View.wfFinanciamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 153px;
        }
        .auto-style3 {
            width: 381px;
            height: 238px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">

        <div class="auto-style3" style="background-color: #87CEEB">
            
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style2">Valor de Financiamento</td>
                    <td>
                        <asp:TextBox ID="valorFinanciamento" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Qtd Parcelas</td>
                    <td><asp:TextBox ID="qtdParcelas" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">Modelo Financiamento</td>
                    <td>
                        <asp:DropDownList ID="dropDownListModeloFinanciamento" runat="server" Width="117px" Height="20px">
                            <asp:ListItem>Outros</asp:ListItem>
                     
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Taxa de Risco</td>
                    <td><asp:TextBox ID="taxaRisco" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>   
                    <td></td>
                    <td>
                        <asp:CheckBox ID="checkBoxDesconto" runat="server" Text="Desconto"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="criarFinanciamento" runat="server" Text="Criar Financiamento" Width="150px" OnClick="criarFinanciamento_OnClick" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Valor Parcela</td>
                    <td><asp:TextBox ID="valorParcela" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">Valor Total Final</td>
                    <td><asp:TextBox ID="valorTotalFinal" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
            </table>
            
        </div>
        <br />
        <div>
            <%-- A propriedade "EnableViewState" do objeto Calendar com o valor falso significa que esse objeto não vai manter o valor entre um
                 postback e outro
                 "Postback" é uma chamada pro servidor --%>
            <asp:Calendar ID="Calendar1" EnableViewState="false" runat="server" OnSelectionChanged="Calendar1_OnSelectionChanged"></asp:Calendar>
            <br />
            <%--Quando cliacamos num botão estamos forçando um "postback", ou seja, uma chamada no servidor --%>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
        
    </form>
</body>
</html>
