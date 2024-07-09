<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <form method="post" action="Default.aspx">
        <input type="text" name="txtNome" value='<%=Request.Form("txtNome") %>' /> <br/> 
        <input type="submit" name="btnInvia" value="INVIA" /><br/><br/>
        Memoria <input type="hidden" name="txtMem" value='<%=Request.Form("txtNome") + " " + Request.Form("txtMem") %>' /> <br/> 
        
    </form>
</body>
</html>