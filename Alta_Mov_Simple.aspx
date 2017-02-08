<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alta_Mov_Simple.aspx.cs" Inherits="Trabajo_final_csharp.Alta_Mov_Simple" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Fecha" CssClass="col-md-2 control-label">Fecha</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Fecha" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Fecha"
                                CssClass="text-danger" />
                        </div>
                    </div>
</asp:Content>
