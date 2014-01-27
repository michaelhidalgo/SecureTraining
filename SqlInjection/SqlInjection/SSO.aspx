<%@ Page Language="C#"  %>
<%
    var ctx = HttpContext.Current;
    if (ctx!=null)
    {
        var request = ctx.Request;
        var response = ctx.Response;
        var target = request["target"];
        response.Redirect(target != null
                              ? "https://sony.teammentor.net/_Customizations/SSO.aspx?username=Sony_SSO&requestToken=907f8b6e10c709110c3a095856032bd4&target=teammentor"
                              : "https://sony.teammentor.net/_Customizations/SSO.aspx?username=Sony_SSO&requestToken=907f8b6e10c709110c3a095856032bd4");
    }
%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TeamMentor redirection</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <p>Redirecting...</p>
    </div>
    </form>
</body>
</html>
