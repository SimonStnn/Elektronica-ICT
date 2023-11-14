'use strict';
const result = document.getElementById('resultaat');
const tbody = document.getElementById('tabelBody');

window.addEventListener('DOMContentLoaded', async () => {
  // Make result visible
  result.style.display = 'block';
  // Fetch data
  const response = await fetch('./resources/data/apisim.json').then(
    (response) => response.json()
  );
  // Extracts key and value
  const [keys, values] = [
    Object.keys(response.Data),
    Object.values(response.Data),
  ];

  // Empty table body
  while (tbody.hasChildNodes()) {
    tbody.removeChild(tbody.firstChild);
  }

  // Fill table body
  values.forEach((data) => {
    // Append a row to the table body
    const row = tbody.insertRow(-1);
    // Fill row with data

    // Append date
    let cell = row.insertCell(-1);
    cell.appendChild(document.createTextNode(data.Date))
    // Append date
    cell = row.insertCell(-1);
    cell.appendChild(document.createTextNode(data.Temp))
    // Append date
    cell = row.insertCell(-1);
    cell.appendChild(document.createTextNode(data.Humi))
    // Append date
    cell = row.insertCell(-1);
    cell.appendChild(document.createTextNode(data.Co2))
  });
});
