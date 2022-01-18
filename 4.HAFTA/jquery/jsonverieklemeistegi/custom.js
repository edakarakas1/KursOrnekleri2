const table=document.getElementById("userTable");
function getUserList(){
    fetch("https://reqres.in/api/users")
    .then(responce=>responce.json())//data ve responce bizim verdiğimiz isim
    .then(data=>{
        console.log(data);
        //arraylerde for of kullanılır
        for(user of data.data){
            table.innerHTML+=` 
            <tr>
            <td>
                <input type="text" class="form-control" id="first_name_${user.id}" value="${user.first_name}">
            </td>
            <td>
                <input type="text" class="form-control" id="last_name_${user.id}" value="${user.last_name}">
            </td>
            <td>
                <input type="text" class="form-control" id="email_${user.id}" value="${user.email}">
            </td>
        </tr>  `

        }
    })
}
getUserList();

//Create İşlemi 
function createUser(){
    let data={
        first_name:document.getElementById("first_name").value || "değer yok",
        last_name:document.getElementById("last_name").value || "değer yok",
        email:document.getElementById("email").value || "değer yok"
    }
    fetch("https://reqres.in/api/users",{
    method:"POST",
    header:{'Content-Type':'application/json'},
    body:JSON.stringify(data)
})
    .then(responce=>responce.json())
    .then(data=>{ table.innerHTML+=` 
    <tr>
    <td>
        <input type="text" class="form-control" id="first_name" value="${data.first_name}">
    </td>
    <td>
        <input type="text" class="form-control" id="last_name" value="${data.last_name}">
    </td>
    <td>
        <input type="text" class="form-control" id="email" value="${data.email}">
    </td>
</tr>  `})}
