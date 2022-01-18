<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="İletisimFormuu.aspx.cs" Inherits="Html_ders1.İletisimFormuu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server" action="https://www.google.com" method="post">
        <label for="isim">Ad:</label>
    <input type="text" name="isim" id="isim" placeholder="İsminizi giriniz"/>
    
      <br /> 
        <br />
    Soyisim
   
    <input type="text" name="soyisim" id="soyisim" placeholder="Soy isminizi giriniz:" />
    <br />
        <br />
        <label>Sevdiğiniz Spor:</label>

        <input type="checkbox" name="Futbol" id="Futbol" />Futbol
        <input type="checkbox" name="Basketbol" id="Basketbol" />Basketbol
        <input type="checkbox" name="Voleybol" id="Voleybol" />Voleybol 
        
        <br />
        <br />
        <label>Cinsiyet:</label>
         <input type="radio" name="gender" value="Erkek"/>Erkek
        <input type="radio" name="gender" value="Kadın"/>Kadın
         <br />
        <br />
        <label>Güvenlik Sorusu:Türkiye'nin başkenti neresidir?</label>
        <br />
        <br />
        <select name="memleket" id="memleket"">
            <br />
            <option value="cevap">Lütfen bir cevap seçiniz</option>
            <option value="Ankara">Ankara</option>
         <option value="İstanbul">İstanbul</option>
             <option value="Kayseri">Kayseri</option>
        </select>
        <br />
       <br />
        <input type="submit"  value="Kayıt"  /> <br />
        <div>
        </div>
    </form>
</body>
</html>
