<%@ Page Title="" Language="C#" MasterPageFile="~/Recurces/Templare/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.Web.Views.PosiblesClientes.PosiblesClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor"runat="server">
	<div class="mx-auto mt-5">
	<%-- PRIMERA SECCIÓN --%>
	  <div class="form-group">
	    <div class="form-row">
		   <div class="col-md12">
			 <asp:Label runat="server" ID="lblTitulo" Text="Posibles Clientes"></asp:Label>  
		   </div>
	    </div>
	 </div>
    <div class="form-group">
	  <div class="form-row">
        <div class="col-md-3">
		  <asp:Label runat="server" ID="lblIdentificacion" Text="Identificacion"></asp:Label>
			<asp:TextBox runat="server" ID="txtIdentificacion" CssClass="form-control"></asp:TextBox>
          </div>
		   <div class="col-md-3">
            <asp:Label runat="server" ID="lblEmpresa" Text="Empresa"></asp:Label>
			 <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-control"></asp:TextBox>
          </div>
		   <div class="col-md-3">
            <asp:Label runat="server" ID="lblPrimerNombre" Text="Primer nombre"></asp:Label>
			 <asp:TextBox runat="server" ID="txtPrimerNombre" CssClass="form-control"></asp:TextBox>
          </div>
		   <div class="col-md-3">
            <asp:Label runat="server" ID="lblSegundoNombre" Text="Segundo nombre"></asp:Label>
			<asp:TextBox runat="server" ID="txtSegundoNombre" CssClass="form-control"></asp:TextBox>
          </div>
	    </div>
       </div> 
	  <%-- SEGUNDA SECCIÓN --%>
	  <div class="form-group">
	  <div class="form-row">
        <div class="col-md-3">
		  <asp:Label runat="server"ID="lblPrimerApellido"Text="Primer apellido"></asp:Label>
			<asp:TextBox runat="server"ID="txtPrimerApellido"CssClass="form-control"></asp:TextBox>
          </div>
		   <div class="col-md-3">
            <asp:Label runat="server"ID="lblSegundoApellido"Text="Segundo apellido"></asp:Label>
			 <asp:TextBox runat="server"ID="txtSegundoApellido"CssClass="form-control"></asp:TextBox>
           </div>
		   <div class="col-md-3">
            <asp:Label runat="server"ID="lblDireccion"Text="Direccion"></asp:Label>
			 <asp:TextBox runat="server"ID="txtDireccion"CssClass="form-control"></asp:TextBox>
          </div>
		   <div class="col-md-3">
            <asp:Label runat="server"ID="lblTelefono"Text="Telefono"></asp:Label>
			<asp:TextBox runat="server"ID="txtTelefono"CssClass="form-control"></asp:TextBox>
         </div>
	  </div>
    </div>
	 <%-- TERCERA SECCIÓN --%>
	 <div class="form-group">
	   <div class="form-row">
		   <div class="col-md12">
             <asp:Label runat="server"ID="lblCorreo"Text="Correo"></asp:Label>
			<asp:TextBox runat="server"ID="txtCorreo"CssClass="form-control"></asp:TextBox>
		    </div>
	   </div>
	 </div>
	  <%-- CUARTA SECCIÓN --%>
	 <div class="form-group">
	   <div class="form-row">
		   <div class="col-md12">
           <asp:Button runat="server"ID="btnGuardar"Text="Guardar"CssClass="btn btn-primary"/>
			 <asp:Button runat="server"ID="btnCancelar"Text="Cancelar"CssClass="btn btn-primary"/>
		    </div>
	    </div>
	 </div>
	 <%-- QUINTA SECCIÓN --%>
	 <div class="form-group">
	    <div class="form-row">
		   <div class="col-md12">
			 <asp:Label runat="server"ID="lblSubtitulo"Text="Resultado"></asp:Label>  
		   </div>
	    </div>
	 </div>
	  <div class="form-group">
	    <div class="form-row">
	      <div class="col-md12">           
		 </div>
	   </div>
	 </div>
  </div>
</asp:Content>
