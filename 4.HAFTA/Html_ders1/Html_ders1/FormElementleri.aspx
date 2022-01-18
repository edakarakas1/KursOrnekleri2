<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormElementleri.aspx.cs" Inherits="Html_ders1.FormElementleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="https://www.google.com" method="post">
       <!--value="İsim"-->
        <label for="isim">Ad</label>
        <input type="text" name="isim" id="isim" placeholder="İsmi giriniz />
        <br />
        Şifre
        <br />
      
        <input type="password" name="sifre" id="sifre" placeholder="Şifrenizi giriniz"/>
        <br />
        <label for="email" style="background-color:red">Mail</label>
        <input type="email" name="email" id="email"/>
       <!--  <input type="text" name="email" id="email"/>-->
         <br />
        <label for="tel">Telefon</label>
        <input type="tel" name="tel" id="tel" pattern="[0-9]{11}"/>
         <br />
        <label>Sayı</label>
        <input type="number" min="1" max="5"/>
         <br />
        <label>Cinsiyet</label>
        <input type="radio" name="gender" value="Erkek"/>Erkek
        <input type="radio" name="gender" value="Kadın"/>Kadın
         <br />
        <select name="memleket" id="memleket">
            <option value="Tekirdağ">Tekirdağ</option>
         <option value="Canakkale">Tekirdağ</option>
        </select>
         <br />
        <input type="checkbox" name="html" id="html" />Html
        <input type="checkbox" name="c#" id="c#" />C#
        <input type="date"  id="date"  min="2015-12-31"/>
        <input type="datetime-local"  id="datetime-local"  min="2015-12-3"/>
        <br />
        <input type="month"  id="month" />  <br />
          <input type="week"  id="week"  /> <br />
          <input type="time"  id="time"  /> <br />

          <input type="submit"  value="Gönder"  /> <br />
       
    </form>
</body>
</html>
