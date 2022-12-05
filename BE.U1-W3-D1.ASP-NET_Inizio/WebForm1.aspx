<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BE.U1_W3_D1.ASP_NET_Inizio.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form">
           <h1> Cinema Multisala</h1>
            <p> Nome</p>
            <asp:TextBox ID="NomeSpettatore" runat="server"></asp:TextBox>
            <p> Cognome</p>
            <asp:TextBox ID="CognomeSpettatore" runat="server"></asp:TextBox>
            <p> Sala</p>
            <asp:DropDownList ID="DropDownList" runat="server"></asp:DropDownList>
            <asp:CheckBox ID="bigliettoRidoto" runat="server" /> Biglietto ridotto <br />
            <asp:Button ID="Buttone" runat="server" Text="Prenota" OnClick="Buttone_Click" />
        </div>
        <div class="InfoVendite">
            <h1> Informazioni Supplementari</h1>

            <div class="SN">
                <p>Sala NORD:  <asp:Label ID="SN_venduto" runat="server" Text=""></asp:Label> 
                    di cui ridotto:  <asp:Label ID="SN_ridotto" runat="server" Text=""></asp:Label> 
                </p>    
            </div>

            <div class="SE">
                <p>Sala EST:  <asp:Label ID="SE_venduto" runat="server" Text=""></asp:Label> 
                    di cui ridotto:  <asp:Label ID="SE_ridotto" runat="server" Text=""></asp:Label> 
                </p>          
            </div>

            <div class="SU">
                <p>Sala SUD:  <asp:Label ID="SS_venduto" runat="server" Text=""></asp:Label> 
                    di cui ridotto:  <asp:Label ID="SS_ridotto" runat="server" Text=""></asp:Label> 
                </p>          
            </div>
        </div>            
    </form>

</body>
</html>
