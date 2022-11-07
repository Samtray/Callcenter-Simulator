export async function createCall(url, body){
    const response = await fetch(url,{
        method:"POST", mode:"cors", credentials:"same-origin",
        body:body
    }).then((response)=>{console.log(response)}).catch((response)=>{
        console.log(response);
    });
}