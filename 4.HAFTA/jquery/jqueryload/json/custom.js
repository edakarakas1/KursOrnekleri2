let data ={
    
    kisiler:[{name:"eda",surname:"karakas",age:27},
    {name:"gül",surname:"yılmaz",age:28},
    {name:"eda",surname:"mutlu",age:20}],
    islem:"GET"
};
//console.log(data);
//console.log(data.kisiler[2].surname);
//var kayit=JSON.stringify(data);//stringe çevirir
//console.log(kayit);
//var cevir =JSON.parse(kayit);//string veriyi jsona çevirir 
//console.log(cevir);
var kisiler=document.getElementById("kisiler");
for(let getir in date)
{
    //console.log(data[getir]);
    // for(deger of data[getir]){
    //     console.log(deger);
    // }
    var gelen =data[getir];
    if(gelen=="kisiler"){
        for(isimler in gelen)
        {
        kisiler.innerHTML+=`<li>${gelen[isimler]["name"]}</li>`
    }
    }
}

