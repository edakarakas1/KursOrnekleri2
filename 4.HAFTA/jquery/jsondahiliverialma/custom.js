/*fetch() api kullanarak verileri çekiyoruz */
var data=fetch("veri.json")
.then(responce=>responce.json())
.then(veri=>{
    console.log(veri);
    console.log(veri.kullanicilar);
    console.log(veri.yetki[0]);
    var veriler=JSON.stringify(veri);
    console.log(veriler);
});