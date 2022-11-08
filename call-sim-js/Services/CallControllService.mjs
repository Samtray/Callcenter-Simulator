export async function createCall(url, body) {
    await fetch(url, {
        method: "POST", mode: "cors", credentials: "include",
        body: body
    }).then((response) => response.json())
        .then((data) => console.log(data))
        .catch((response) => {
            console.log(response);
        });

    console.log("test")
}