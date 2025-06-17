document.getElementById("searchInput").addEventListener("keyup", function () {
  const query = this.value;

  if (query.length < 2) return; // çok kısa sorguları atla

  const xhttp = new XMLHttpRequest();
  xhttp.onload = function () {
    if (this.status === 200) {
      const data = JSON.parse(this.responseText);
      const list = document.getElementById("results");
      list.innerHTML = "";

      data.forEach(item => {
        const li = document.createElement("li");
        li.textContent = item.title;
        list.appendChild(li);
      });
    }
  };

  xhttp.open("GET", `https://newsapi.org/v2/everything?q=tesla&from=2025-05-17&sortBy=publishedAt&apiKey=f47028e02a4c43f789fcfb764b5cc113=${query}`, true);
  xhttp.send();
});