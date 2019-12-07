<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 565px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <br />
       <br />
       <br />
       <br />
       <table>
                <tr>
                    <td class="auto-style7" colspan="2">THÊM SẢN PHẨM</td>
                </tr>
                <tr><td>Mã sản phẩm</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtmasp" runat="server" Height="16px" Width="216px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtmasp" ErrorMessage="Chưa nhập mã sản phẩm"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Tên sản phẩm</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txttensp" runat="server" Height="16px" Width="217px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txttensp" ErrorMessage="Chưa nhập tên sản phẩm"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr><td class="auto-style7">Giá</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtgia" runat="server" Height="16px" Width="218px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtgia" ErrorMessage="Chưa nhập giá sản phẩm"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtgia" ErrorMessage="Phải là số tiền" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                    </td>
                </tr>
                <tr><td class="auto-style7">Mô tả</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtmota" runat="server" Height="16px" Width="216px"></asp:TextBox></td>
                </tr>
                <tr><td class="auto-style7">Hình ảnh</td>
                    <td class="auto-style6">
                        <asp:FileUpload ID="fulhinhanh" runat="server" /></td>
                </tr>
                <tr><td class="auto-style7" colspan="2">
                    <asp:Button ID="btthem" runat="server" Text="Thêm" Width="127px" OnClick="btthem_Click" />
                    <asp:Label ID="lbthemsanpham" runat="server" Enabled="False" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:GridView ID="Gv1" runat="server" DataKeyNames="masp" OnRowCancelingEdit="Gv1_RowCancelingEdit" OnRowDeleting="Gv1_RowDeleting" OnRowEditing="Gv1_RowEditing" OnRowUpdating="Gv1_RowUpdating" Width="1103px" AutoGenerateColumns="False">
           <Columns>
               <asp:BoundField DataField="masp" HeaderText="Mã sản phẩm" />
               <asp:BoundField DataField="tensp" HeaderText="Tên sản phẩm" />
               <asp:BoundField DataField="gia" HeaderText="Giá" />
               <asp:BoundField DataField="mota" HeaderText="Chi tiết sản phẩm" />
               <asp:BoundField DataField="hinhanh" HeaderText="Hình ảnh" />
               <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
           </Columns>
       </asp:GridView>
                    </td></tr>
            </table>
            <br />
           
</asp:Content>

