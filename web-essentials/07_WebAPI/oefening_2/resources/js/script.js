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
    cell.appendChild(document.createTextNode(data.Date));
    // Append date
    cell = row.insertCell(-1);
    cell.appendChild(document.createTextNode(data.Temp));
    // Append date
    cell = row.insertCell(-1);
    cell.appendChild(document.createTextNode(data.Humi));
    // Append date
    cell = row.insertCell(-1);
    cell.appendChild(document.createTextNode(data.Co2));
  });

  // Make Google charts
  google.charts.load('current', { packages: ['line'] });
  google.charts.setOnLoadCallback(() => {
    // Create chart
    const data = new google.visualization.DataTable();
    // Add columns
    data.addColumn('date', 'Datum');
    data.addColumn('number', 'Temperatuur');
    data.addColumn('number', 'Luchtvochtigheid');
    data.addColumn('number', 'CO2');

    // Add data to table
    values.forEach((gegevens) => {
      data.addRow([
        new Date(gegevens.Date),
        parseFloat(gegevens.Temp),
        parseFloat(gegevens.Humi),
        parseFloat(gegevens.Co2),
      ]);
    });

    // Set options
    const options = {
      chart: {
        title: 'History graph',
        subtitle: 'in de kelder',
      },
      width: '100%',
      height: 690,
      series: {
        0: { axis: 'Data' },
      },
      hAxis: {
        title: 'Datum',
        format: 'd/M/yy',
        gridlines: { count: 15 },
      },
      axes: {
        y: {
          temp: { label: 'Temperatuur [°C]' },
          humi: { label: 'Luchtvochtigheid [%]' },
          co2: { label: 'CO2 [ppm]' },
        },
      },
      legend: {
        position: 'none',
      },
    };

    const chart = new google.charts.Line(document.getElementById('chart'));
    chart.draw(data, google.charts.Line.convertOptions(options));
  });
});
