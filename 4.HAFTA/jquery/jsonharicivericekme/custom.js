// var listele=document.getElementById("listele")
// let data=fetch("http://jsonplaceholder.typicode.com/posts")
// .then(response=>response.json()
// ).then(veri =>{
//     veri.forEach(element => {
//         //console.log(element.title)
//         if(element.id<=10){
//             listele.innerHTML+=`<li>${element.title}</li>`// ```Alt Gr , ile gelir
//         }
//     });
// });

var listele=document.getElementById("album")
let data=fetch("http://jsonplaceholder.typicode.com/photos")
.then(response=>response.json()
).then(veri =>{
    veri.forEach(element => {
        //console.log(element.title)
        if(element.id<=10){
            listele.innerHTML+=`<img src="${element.url}">`
        }
    });
});