﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Condominios.SRCuota.DCuota>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Colocar Cuota
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Crear</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdCuota) %>
            </div>
            <div class="editor-field"> 
                <%: Html.TextBoxFor(model => model.IdCuota) %>
                <%: Html.ValidationMessageFor(model => model.IdCuota) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Vivienda) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Vivienda)%>
                <%: Html.ValidationMessageFor(model => model.Vivienda)%>
            </div>            

            <div class="editor-label">
                <%: Html.LabelFor(model => model.Mes) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Mes) %>
                <%: Html.ValidationMessageFor(model => model.Mes) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Anio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Anio) %>
                <%: Html.ValidationMessageFor(model => model.Anio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Importe) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Importe) %>
                <%: Html.ValidationMessageFor(model => model.Importe) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaVencimiento) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaVencimiento) %>
                <%: Html.ValidationMessageFor(model => model.FechaVencimiento) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Estado) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Estado) %>
                <%: Html.ValidationMessageFor(model => model.Estado) %>
            </div>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la lista", "Index")%>
    </div>

</asp:Content>

