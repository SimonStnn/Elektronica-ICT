const ip = document.getElementById('ip');
const stad = document.getElementById('stad');
const land = document.getElementById('land');
const coordinaten = document.getElementById('coordinaten');

async function getIp() {
  const url = 'https://ipapi.co/json/';

  const response = await fetch(url).then((response) => response.json());

  ip.textContent = `Jou IP-adress is ${response.ip}`;
  stad.textContent = `Je stad is ${response.city}`;
  land.textContent = `Je land is ${response.country_name}`;
  coordinaten.textContent = `Jou coordinaten zijn ${response.latitude}, ${response.longitude}`;
}
