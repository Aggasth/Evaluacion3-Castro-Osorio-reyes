<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="EvaluacionASP_Castro_Osorio_Reyes.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container" style="background-color:beige; border-radius:10px; display:flex; justify-content: center; text-align: center;">
        <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="row" style="display: flex; justify-content:center;text-align:center;">
                    <div class="mb-9">
                        <label for="VerMedidores" class="form-label"><h2>Ver Medidores</h2></label><br />
                        <asp:Button ID="btnRefresh" CssClass="btn btn-secondary" OnClick="btnRefresh_Click" runat="server" Text="Refrescar" />
                    </div>
                    <div class="mb-6">
                        <label><h4>Seleccione un filtro: </h4></label>
                        <asp:DropDownList ID="dplFiltro" runat="server" OnSelectedIndexChanged="dplFiltro_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Value="1" Text="Agua"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Luz"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Gas"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="mb-6">
                        <asp:GridView ID="gridMedidores" runat="server" EmptyDataText="No hay medidores" CssClass="table" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id del medidor" />
                                <asp:BoundField DataField="Tipo" HeaderText="Tipo del medidor" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
