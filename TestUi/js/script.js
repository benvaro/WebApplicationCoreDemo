var url = "https://localhost:44342/films";

onload = async () => {
    var responce = await fetch(url);
    var data = await responce.json();

    console.log(data);
}