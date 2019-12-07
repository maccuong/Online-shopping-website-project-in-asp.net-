<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Trangchu.aspx.cs" Inherits="Trangchu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 823px;
        }
        .auto-style4 {
            width: 1018px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            height: 195px;
        }
        .auto-style7 {
            margin-left:50px;
            margin-right:50px;
            width: 918px;
            height: 141px;
        }
        .auto-style8 {
            width: 794px;
            height: 57px;
        }
        .auto-style9 {
            height: 29px;
        }
        .auto-style10 {
            height: 32px;
        }
        </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
    <div class="banchay01">
      <div>
    
          <br />
          <br />
          <br />
          <br />
    
        Xin chào, &nbsp; <b><asp:LoginName ID="LoginName1" runat="server" /></b>&nbsp;&nbsp;&nbsp;
    
        <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="RedirectToLoginPage" LogoutPageUrl="~/Trangchu.aspx" />
    
          <br />
          <asp:Button ID="btthemsanpham" runat="server" OnClick="btthemsanpham_Click1" Text="Thêm sản phẩm mới" Width="152px" Visible="False" />
    
          <asp:Button ID="btXemtk" runat="server" OnClick="Button3_Click" Text="Xem danh sách tài khoản" Width="171px" Visible="False" />
    
    </div>
   <div>
   
        <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="Sản phẩm"></asp:Label>
   
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="4"  >
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" Height="217px" ImageUrl='<%# "~/hinh/"+Eval("hinhanh") %>' Width="229px" />
                <br />
                <br />
                <asp:Label ID="Label21" runat="server" Text='<%# Eval("gia") %>'></asp:Label>
                <br />
                <asp:Label ID="Label22" runat="server" Text='<%# Eval("mota") %>'></asp:Label>
                <br />
                <asp:Label ID="Lbmasp" runat="server" Text='<%# Eval("masp") %>'></asp:Label>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "chitiet.aspx?ma="+Eval("masp") %>' Text='<%# "Chi tiết"+Eval("masp") %>'></asp:HyperLink>
                <br />
            </ItemTemplate>
        </asp:DataList>
   
        </div>
                  
       



     </div>
        <div class="auto-style6" style="background-color:#660066; color: #FFFFFF;" >
            <br />
            <table class="auto-style7" style="border-style: none; border-spacing: 0px; font-family: 'Times New Roman', Times, serif; font-size: large;">
                <tr><td>140 Lê Trọng Tấn, p.Tây Thạnh, q.Tân Phú, Tp.HCM</td>
                    <td style="font-size: x-large">TÀI KHOẢN</td>
                </tr>
                <tr>
                    <td>ĐT:0326305946</td>
                    <td>
                        <asp:Button ID="Btdangnhap" runat="server" Text="Đăng nhập" BackColor="#660066" BorderColor="#660066" BorderWidth="0px" ForeColor="White" OnClick="Btdangnhap_Click" Width="94px" /></td>

                </tr>
                <tr><td>Giờ mở cửa:T2-T7:9h00-17h30</td>
                      <td>
                          <asp:Button ID="bttaotaikhoan" runat="server" Text="Tạo tài khoản" BackColor="#660066" BorderColor="#660066" BorderWidth="0px" ForeColor="White" OnClick="bttaotaikhoan_Click" Width="92px" /></td>
                </tr>
                <tr><td style="font-size: x-large; font-style: italic">BABI-Thời trang trẻ em</td></tr>
              
            </table>
        </div>
                   </asp:View>
        <asp:View ID="View2" runat="server" OnActivate="bttaotaikhoan_Click">
            <div >
                <table class="auto-style8">
                    <tr><td style="border-bottom:1px">ĐĂNG KÍ TÀI KHOẢN MỚI</td></tr>
                    <tr>
                        <td class="auto-style9">Email*</td>
                        </tr>
                    <tr><td>
                            <asp:TextBox ID="txtEmailmoi" runat="server" Width="482px" Height="16px"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtEmailmoi" ErrorMessage="*" Operator="DataTypeCheck" ValueToCompare="1"></asp:CompareValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmailmoi" ErrorMessage="Chưa nhập email"></asp:RequiredFieldValidator>
                        </td>
                    </tr><tr>
                        <td class="auto-style10">Mật khẩu*</td>
                         </tr>
                     <tr><td>
                        <asp:TextBox ID="txtmatkhaumoi" runat="server" Width="496px" TextMode="Password"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtmatkhaumoi" ErrorMessage="Chưa nhập  mật khẩu"></asp:RequiredFieldValidator>
                         </td></tr>
                    <tr>
                   
                        <td>
                            Xác nhận mật khẩu</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtxacnhanmatkhau" runat="server" Width="495px" TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtmatkhaumoi" ControlToValidate="txtxacnhanmatkhau" ErrorMessage="Hai mật khẩu không giống nhau"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="BtDangki" runat="server" Text="Đăng kí" Width="88px" OnClick="BtDangki_Click" />
                            <asp:Label ID="lbthemtaikhoan" runat="server" Enabled="False" Text="Label"></asp:Label>
                        </td>
                         </tr>
                </table>
            </div>
        </asp:View>
        <asp:View ID="View3" runat="server">
            <div>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:GridView ID="Gvtk" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:BoundField DataField="matk" HeaderText="Mã tài khoản" />
                        <asp:BoundField DataField="email" HeaderText="Email" />
                        <asp:BoundField DataField="loaitk" HeaderText="Loại tài khoản" />
                        <asp:BoundField DataField="matv" HeaderText="Mã thành viên" />
                        <asp:BoundField DataField="tentv" HeaderText="Tên thành viên" />
                        <asp:BoundField DataField="diachi" HeaderText="Địa chỉ " />
                        <asp:BoundField DataField="dt" HeaderText="Điện thoại" />
                    </Columns>
                </asp:GridView>
            </div>
        </asp:View>
       
        </asp:MultiView>
</asp:Content>

