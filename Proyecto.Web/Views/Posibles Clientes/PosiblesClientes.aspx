<%@ Page Title="" Language="C#" MasterPageFile="~/Recurces/Templare/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.Web.Views.Posibles_Clientes.PosiblesClientes" %>

<asp:Content ID="ContentHeader" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
	<script src="../../js/sweetalert.min.js" type="text/javascript"></script>
	<link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
   <div class="mx-auto mt-5">
	<%--PRIMERA SECCIÓN--%>
	  <div class="form-group">
	    <div class="form-row">
		   <div class="col-md-12">
			   <h1>
				 <b>Posibles Clientes</b>
				   <asp:Label runat="server" ID="lblOpcion" Visible="false"></asp:Label>
			   </h1>			   
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
             <asp:Label runat="server" ID="lblPrimerNombre" Text="Primer Nombre"></asp:Label>
			  <asp:TextBox runat="server" ID="txtPrimerNombre" CssClass="form-control"></asp:TextBox>
            </div>
		  <div class="col-md-3">
            <asp:Label runat="server" ID="lblSegundoNombre" Text="Segundo Nombre"></asp:Label>
			<asp:TextBox runat="server" ID="txtSegundoNombre" CssClass="form-control"></asp:TextBox>
          </div>
	    </div>
       </div> 
	  <%-- SEGUNDA SECCIÓN --%>
	  <div class="form-group">
	  <div class="form-row">
        <div class="col-md-3">
		    <asp:Label runat="server" ID="lblPrimerApellido" Text="Primer Apellido"></asp:Label>
		    <asp:TextBox runat="server" ID="txtPrimerApellido" CssClass="form-control"></asp:TextBox>
       </div>
	   <div class="col-md-3">
          <asp:Label runat="server" ID="lblSegundoApellido" Text="Segundo Apellido"></asp:Label>
		  <asp:TextBox runat="server" ID="txtSegundoApellido" CssClass="form-control"></asp:TextBox>
          </div>
	      <div class="col-md-3">
             <asp:Label runat="server" ID="lblDireccion" Text="Dirección"></asp:Label>
			 <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
          </div>
		  <div class="col-md-3">
            <asp:Label runat="server" ID="lblTelefono" Text="Teléfono"></asp:Label>
			<asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control"></asp:TextBox>
         </div>
	  </div>
    </div>
	 <%-- TERCERA SECCIÓN --%>
	 <div class="form-group">
	   <div class="form-row">
		   <div class="col-md-12">
             <asp:Label runat="server" ID="lblCorreo" Text="Correo"></asp:Label>
			<asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
		    </div>
	      </div>
	   </div>
	  <%-- CUARTA SECCIÓN --%>
	 <div class="form-group">
	   <div class="form-row">
		   <div class="col-md-12">
            <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-dark" OnClick="btnGuardar_Click"/>
			 <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click"/>
		   </div>
	    </div>
	 </div>
	   <div>
	   </div>
	 <%-- QUINTA SECCIÓN --%>
	 <div class="form-group">
	    <div class="form-row">
		   <div class="col-md-12" style="overflow:auto">
			  <h3>
				 <b>Resultados</b>
			   </h3>	 
		   </div>
	    </div>
	 </div>
   <asp:GridView runat="server" ID="gvwDatos" 
	 Width="100%" AutoGenerateColumns="False" 
	 EmptyDataText="No se encontraron registros" 
      BackColor="White" BorderColor="#999999" BorderStyle="None" 
	    BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowCommand="GvwDatos_RowCommand">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
   <%--RESPRESENTACIÓN DE DATOS EN CONTROLES WEB--%>
            <asp:TemplateField HeaderText="Identificacion">
				<ItemTemplate>
					<asp:Label runat="server" ID="lblIdentificacion" Text='<%# Bind("ClieIdentificacion") %>'></asp:Label>
				</ItemTemplate>
            </asp:TemplateField>
			   <%--REPRESENTACIÓN DE DATOS EN CELDAS--%>
               <asp:BoundField HeaderText="Empresa" DataField="ClieEmpresa"/>
		       <asp:BoundField HeaderText="Primer Nombre" DataField="CliePrimerNombre"/>
			   <asp:BoundField HeaderText="Segundo Nombre" DataField="ClieSegundoNombre"/>
			   <asp:BoundField HeaderText="Primer Apellido" DataField="CliePrimerApellido"/>
			   <asp:BoundField HeaderText="Segundo Apellido" DataField="ClieSegundoApellido"/>
			   <asp:BoundField HeaderText="Direccion" DataField="ClieDireccion"/>
			   <asp:BoundField HeaderText="Telefono" DataField="ClieTelefono"/>
			   <asp:BoundField HeaderText="Correo" DataField="ClieCorreo"/>

			 <%-- EDITAR --%>
			 <asp:TemplateField HeaderText="Editar">
				<ItemTemplate>
					<asp:ImageButton ID="ibEditar" runat="server" ImageUrl="~/Recurces/Images/Editar.png"
					commandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
				</ItemTemplate>
				 <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

			 <%-- ELIMINAR --%>
			 <asp:TemplateField HeaderText="Eliminar">
				<ItemTemplate>
					<asp:ImageButton ID="ibEliminar" runat="server" ImageUrl="~/Recurces/Images/Cancel.png"
						commandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
				</ItemTemplate>
				 <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>

        </Columns>

    	<FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
		<HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
		<PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
		<RowStyle BackColor="#EEEEEE" ForeColor="Black" />
		<SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
		<SortedAscendingCellStyle BackColor="#F1F1F1" />
		<SortedAscendingHeaderStyle BackColor="#0000A9" />
		<SortedDescendingCellStyle BackColor="#CAC9C9" />
		<SortedDescendingHeaderStyle BackColor="#000065" />

    </asp:GridView>
	  <div class="form-group">
	    <div class="form-row">
	      <div class="col-md-12">           
		 </div>
	   </div>
    </div>
   </div>
</asp:Content>
