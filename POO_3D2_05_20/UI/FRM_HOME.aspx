﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FRM_HOME.aspx.cs" Inherits="POO_3D2_05_20.UI.FRM_HOME" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Livraria</title>
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="col-12">
            <div style="text-align:center; margin-top:10px;">
                <div class="row">
                     <div class="col-4"></div>
                         <div class="col-4">
                            <div class="card">
                                <div class="card-header">
                                    <h3>Cadastro livros</h3>
                                </div>
                                <div class="card-body">
                                    <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
                                     <div class="form-group">
                                       <asp:Label ID="lbl_autor" runat="server" Text="ID Autor"></asp:Label>
                                    <asp:TextBox ID="txt_autor" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div><br />
                                     <div class="form-group">
                                       <asp:Label ID="lbl_editora" runat="server" Text="ID Editora"></asp:Label>
                                    <asp:TextBox ID="txt_editora" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div><br />

                                <div class="form-group">
                                    <asp:Label ID="lbltitulo" runat="server" Text="Título"></asp:Label>
                                    <asp:TextBox ID="txttitulo" type="text" runat="server" CssClass="form-control"></asp:TextBox>
                                </div><br />

                                    <div class="form-group">
                                        <asp:Label ID="lbldatacadastro" runat="server" Text="Data Cadastro"></asp:Label>
                                    <asp:TextBox ID="txtdatacadastro" type="date" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div><br />

                                    <div class="form-group">
                                        <asp:Label ID="lblnumpaginas" runat="server" Text="Número de páginas"></asp:Label>
                                    <asp:TextBox ID="txtnumpaginas" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div><br />

                                     <div class="form-group">
                                       <asp:Label ID="lblvalor" runat="server" Text="Valor"></asp:Label>
                                    <asp:TextBox ID="txtvalor" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div><br />

                                        <asp:Button ID="btn_cadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-block" OnClick="btn_cadastrar_Click" />                                
                           
                                </div>
                           
                         </div>
                    </div>
                    <div class="col-4"></div>
                </div>
            </div>
             <div class="row mt-4">
                 <div class="col-2"></div>
                 <div class="col-8">
                     <asp:GridView ID="GridLivraria" CssClass="table table-striped" runat="server" AllowPaging="True" PageSize="5" OnPageIndexChanging="GridLivraria_PageIndexChanging" OnRowCancelingEdit="GridLivraria_RowCancelingEdit" OnRowDeleting="GridLivros_RowDeleting" OnRowEditing="GridLivros_RowEditing" OnRowUpdating="GridLivros_RowUpdating">
                        <Columns>
                            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                            <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                        </Columns> 
                         <PagerSettings PageButtonCount="5" Position="TopAndBottom" />
                    </asp:GridView>
                 </div>
                 <div class="col-2"></div>
             </div>
        </div>
    </form>
</body>
</html>
