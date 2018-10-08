<%@ Page Title="" Language="C#" MasterPageFile="~/Recurces/Templare/Template.Master" AutoEventWireup="true" CodeBehind="Tareas.aspx.cs" Inherits="Proyecto.Web.Views.Tareas.Tareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
<script src="../../js/sweetalert.min.js" type="text/javascript"></script>
<link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
	<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
	<div class="container">
		<div class="card mx-auto mt-5">
			<div class="card-header">Crear Tareas</div>
			<div class="card-body">
			<%-- Fila 1--%>
				<div class="form-group">
					<div class="form-row">
						<div class="col-md-12">
							<h1>
								<b>Información Sobre la Tarea</b>
								<asp:label runat="server" id="lblOpcion" visible="false"></asp:label> 
							</h1>
						</div>
					</div>
				</div>
				<%-- Fila 2--%>
				<div class="form-group">
					<div class="form-row">
						<div class="col-md-6">
							<asp:Label runat="server" id="lblTitularTarea" Text="Titular Tarea"></asp:Label> 
							<asp:textbox runat="server" id="txtTitularTarea" CssClass="form-control"></asp:textbox>
							<ajaxToolkit:textboxwatermarkextender id="twmtTitularTarea"	runat="server"
								targetcontrolid="txtTitularTarea"
								watermarktext="Titular Tarea"/>
						</div>
						<div class="col-md-6">
							<asp:Label runat="server" id="lblAsunto" Text="Asunto"></asp:Label> 
							<asp:textbox runat="server" id="txtAsunto" CssClass="form-control"></asp:textbox>
							<ajaxToolkit:textboxwatermarkextender id="twmtAsunto" runat="server"
								targetcontrolid="txtAsunto"
								watermarktext="Asunto"/>
						</div>
					</div>
				</div>
				<%-- Fila 3--%>
				<div class="form-group">
					<div class="form-row">
						<div class="col-md-6">
							<asp:Label runat="server" id="lblFechaVencimiento" Text="Fecha de Vencimiento"></asp:Label> 
							<asp:textbox runat="server" id="txtFechaVencimiento" CssClass="form-control"></asp:textbox>
							<ajaxToolkit:textboxwatermarkextender id="twmtFechaVencimiento" runat="server"
								targetcontrolid="txtFechaVencimiento"
								watermarktext="Fecha de Nacimiento"/>
							<ajaxToolkit:CalendarExtender ID="cefecahaVencimiento" runat="server" TargetControlID="txtFechaVencimiento" />
						</div>
						<div class="col-md-6">
							<asp:Label runat="server" id="lblContacto" Text="Contacto"></asp:Label> 
							<asp:textbox runat="server" id="txtContacto" CssClass="form-control"></asp:textbox>
							<ajaxToolkit:textboxwatermarkextender id="twmtContacto" runat="server"
								targetcontrolid="txtContacto"
								watermarktext="Contacto"/>
						</div>
					</div>
				</div>

					<%-- Fila 4--%>
				<div class="form-group">
					<div class="form-row">
						<div class="col-md-6">
							<asp:Label runat="server" id="lblCuenta" Text="Cuenta"></asp:Label> 
							<asp:textbox runat="server" id="txtCuenta" CssClass="form-control"></asp:textbox>
							<ajaxToolkit:textboxwatermarkextender id="twmtCuenta" runat="server"
								targetcontrolid="txtCuenta"
								watermarktext="Cuenta"/>
							<ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFechaVencimiento" />
						</div>
						<div class="col-md-6">
							<asp:Label runat="server" id="lblEstado" Text="Estado"></asp:Label> 
							<asp:DropDownList runat="server" id="ddlEstado" CssClass="form-control"></asp:DropDownList>							
						</div>
					</div>
				</div>

					<%-- Fila 5--%>
				<div class="form-group">
					<div class="form-row">
						<div class="col-md-6">
							<asp:Label runat="server" id="lblPrioridad" Text="Prioridad"></asp:Label> 
							<asp:DropDownList runat="server" id="ddlPrioridad" CssClass="form-control"></asp:DropDownList>							
						</div>
						<div class="col-md-6">
							<asp:Label runat="server" id="lblEnviarMensaje" Text="Enviar Mensaje">
							<asp:CheckBox runat="server" id="chkEnviarMensaje" CssClass="form-control"></asp:CheckBox>	
							</asp:Label> 
						</div>
					</div>
				</div>

				<%-- Fila 6--%>
				<div class="form-group">
					<div class="form-row">
						<div class="col-md-6">
							<asp:Label runat="server" id="lblRepetir" Text="Repetir"> 
							<asp:CheckBox runat="server" id="chkRepetir" CssClass="form-control"></asp:CheckBox>	
							</asp:Label>	
						</div>
						<div class="col-md-6">
							<asp:Label runat="server" id="lblDescripcion" Text="Descripción"></asp:Label> 
							<asp:TextBox runat="server" id="txtDescripcion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>	
							<ajaxToolkit:textboxwatermarkextender id="twmtDescripcion" runat="server"
								targetcontrolid="txtDescripcion"
								watermarktext="Descripción"/>
						</div>
					</div>
				</div>

			</div>
		</div>
	</div>


</asp:Content>
