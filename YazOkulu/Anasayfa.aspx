<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="YazOkulu.Anasayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">

        <div class="form-group">

            <div>
                <asp:Label For="txtOgrenci_Ad" runat="server" Text="Öğrenci Adı:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtOgrenci_Ad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div> 
                <asp:Label For="txtOgrenci_Soyad" runat="server" Text="Öğrenci Soyadı:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtOgrenci_Soyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />  
            <div>
                <asp:Label For="txtOgrenci_Numara" runat="server" Text="Öğrenci Numarası:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtOgrenci_Numara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div> 
                <asp:Label For="txtOgrenci_Sifre" runat="server" Text="Öğrenci Şifre:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtOgrenci_Sifre" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            </div>
              <br />
            <div> 
                <asp:Label For="txtOgrenci_Fotograf" runat="server" Text="Öğrenci Fotoğrafı:" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtOgrenci_Fotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
     
        <asp:Button ID="btnOgrenci_Kaydet" runat="server" Text="Kaydet" OnClick="btnOgrenci_Kaydet_Click" Width="79px" CssClass="btn btn-success" />
    </form>

</asp:Content>
