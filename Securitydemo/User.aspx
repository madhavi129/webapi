<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Securitydemo.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" OnCreatedUser="CreateUserWizard1_CreatedUser" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" ActiveStepIndex="1">
                <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
                <WizardSteps>
                    <asp:CreateUserWizardStep runat="server" />
                    <asp:WizardStep ID="AssignRole" runat="server" Title="Assign Role" StepType="Step">
                        Select Role:
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="RoleName" DataValueField="RoleName" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>admin</asp:ListItem>
                            <asp:ListItem>manager</asp:ListItem>
                            <asp:ListItem>sr manager</asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MphasisNorthwind %>" SelectCommand="SELECT [RoleName] FROM [vw_aspnet_Roles]"></asp:SqlDataSource>
                    </asp:WizardStep>
                    <asp:CompleteWizardStep runat="server" >
                        <ContentTemplate>
                            <table style="font-family:Verdana;font-size:100%;">
                                <tr>
                                    <td style="color:White;background-color:#6B696B;font-weight:bold;">Complete</td>
                                </tr>
                                <tr>
                                    <td>Your account has been successfully created.</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="ContinueButton" runat="server" BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Continue" Font-Names="Verdana" ForeColor="#284775" OnClick="ContinueButton_Click" Text="Continue" ValidationGroup="CreateUserWizard1" />
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:CompleteWizardStep>
                </WizardSteps>
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" HorizontalAlign="Center" />
                <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="#FFFFFF" />
                <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                <StepStyle BorderWidth="0px" />
            </asp:CreateUserWizard>
        </div>
    </form>
</body>
    </html>