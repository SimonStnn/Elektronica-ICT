const img = document.getElementById("shape");

window.addEventListener("DOMContentLoaded", () => {
  let i = 0;
  setInterval(() => {
    img.src = `./resources/images/photo0${(i % 6)}.png`;
    i++;
  }, 500);
});
