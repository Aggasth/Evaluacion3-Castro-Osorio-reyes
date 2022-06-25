<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="EvaluacionASP_Castro_Osorio_Reyes.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container" style="background-color:beige; border-radius:10px; display:flex; justify-content: center; text-align: center;">
        <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="row" style="display: flex; justify-content:center;text-align:center;">
                    <div class="mb-9">
                        <label for="VerMedidores" class="form-label"><h2>Ver Lecturas de Medidores</h2></label><br />
                        <asp:Button ID="btnRefresh" CssClass="btn btn-secondary" OnClick="btnRefresh_Click" runat="server" Text="Refrescar" />
                    </div>
                    <div class="mb-6">
                        <label>Seleccione un medidor: </label>
                        <asp:DropDownList ID="dplMedidor" runat="server"  OnSelectedIndexChanged="dplMedidor_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Text="" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblTest" runat="server"></asp:Label>
                    </div>
                    <div class="mb-6">
                        <asp:GridView ID="gridLecturas" runat="server" EmptyDataText="No hay lecturas" CssClass="table" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id del medidor" />
                                <asp:BoundField DataField="fechaLectura" HeaderText="Fecha de Lectura" />
                                <asp:BoundField DataField="Hora" HeaderText="Hora" />
                                <asp:BoundField DataField="Minutos" HeaderText="Minutos" />
                                <asp:BoundField DataField="Consumo" HeaderText="Consumo" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
