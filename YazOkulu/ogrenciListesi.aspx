<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ogrenciListesi.aspx.cs" Inherits="YazOkulu.ogrenciListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr Class="table tab-content alert-danger active  ">
            <th class=" text-center">Öğrenci ID</th>
            <th class=" text-center">Öğrenci Adı</th>
            <th class=" text-center">Öğrenci Soyadı</th>
            <th class=" text-center">Öğrenci Numarası</th>
            <th class=" text-center">Öğrenci Şifresi</th>
            <th class=" text-center">Öğrenci Fotoğrafı</th>
            <th class=" text-center">Öğrenci Bakiyesi</th>
            <th class=" text-center">İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                        <tr class="table table-condensed info text-center">
                            <td><%#Eval("OgrenciId")%></td>
                            <td><%#Eval("OgrenciAd")%></td>
                            <td><%#Eval("Ogrencisoyad")%></td>
                            <td><%#Eval("OgrenciNumara")%></td>
                            <td><%#Eval("Ogrencisifre")%></td>
                            <td><%#Eval("OgrenciFotograf")%></td>
                            <td><%#Eval("OgrenciBakiye")%></td>

                            <td>
                                <asp:HyperLink NavigateUrl='<%#"~/OgrenciSil.aspx?OGRID=" + Eval("OgrenciId")%>' ID="HypLnkSil" runat="server" CssClass ="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OGRID=" + Eval("OgrenciId")%>' ID="HypLnkGuncelle" runat="server" CssClass ="btn btn-success">Güncelle</asp:HyperLink>

                            </td>

                        </tr>
                 </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
