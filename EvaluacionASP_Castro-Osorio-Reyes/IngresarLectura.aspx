<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="EvaluacionASP_Castro_Osorio_Reyes.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container" style="background-color:aliceblue; border-radius:10px; display:flex; justify-content: center; text-align: center;">
        <div class="row">
            <div class="col-lg-6 mx-auto">
                <div class="row" style="display: flex; justify-content:center;text-align:center;">
                        <div class="mb-3">
                        <label for="TituloAgregar" class="form-label"><h2>Ingresar Lectura de Medidores</h2></label>
                    </div>
                    <div class="mb-3">
                        <label for="Medidor" class="form-label">Seleccione el medidor por su ID:</label>
                        <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="dplMedidores" ErrorMessage="Campo Requerido!" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:DropDownList ID="dplMedidores" runat="server" CssClass="form-select">

                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="fechaMedidor">Seleccione la fecha de lectura: 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMinutos" ErrorMessage="Campo Requerido!" ForeColor="Red"></asp:RequiredFieldValidator>
                        </label>
                        <asp:Calendar ID="Calendario" runat="server"></asp:Calendar>
                    </div>
                    <div class="input-group mb-3">
                        <span class="input-group-text">Hora:</span>
                        <asp:TextBox ID="txtHora" type="number" runat="server"></asp:TextBox>
                        <span class="input-group-text">Minutos:</span>
                        <asp:TextBox ID="txtMinutos" type="number" runat="server"></asp:TextBox>
                        
                    </div>
                    <div class="mb-3">
                        <asp:RequiredFieldValidator ID="rfvHora" runat="server" ControlToValidate="txtHora" ErrorMessage="Campo Requerido!" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeHora" ControlToValidate="txtHora" MinimumValue="1" MaximumValue="24" Type="Integer" runat="server" Text="Horas entre 1 y 24" EnableClientScript="false"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="rfvMinutos" runat="server" ControlToValidate="txtMinutos" ErrorMessage="Campo Requerido!" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeMinutos" ControlToValidate="txtMinutos" MinimumValue="1" MaximumValue="60" Type="Integer" runat="server" Text="Minutos entre 1 y 60" EnableClientScript="false"></asp:RangeValidator>
                    </div>

                    <div class="mb-3">
                        <label for="consumoMedidor" class="form-label">Consumo del Medidor: </label>
                        <asp:TextBox ID="txtConsumo" type="number" max="600" MaxLength="3" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvConsumo" runat="server" ControlToValidate="txtConsumo" ErrorMessage="Campo Requerido!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-4">
                        <asp:Button ID="btnIngresar" runat="server" CssClass="btn btn-secondary" Text="Ingresar Medidor" OnClick="btnIngresar_Click" />
                    </div>
                    <div class="mb-3">
                        <asp:Label runat="server" ID="successMsg2" CssClass="text-success"></asp:Label>
                        <asp:Label runat="server" ID="errorMsg2" CssClass="text-danger"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
