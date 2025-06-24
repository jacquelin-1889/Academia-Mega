const express = require('express');

const app = express();
const PORT = process.env.PORT || 3000;

app.get('/', (req, res) => {
  res.send('Holi, mundo!!! \n Autor: Elvia Jaquelin Gonzalez Macias');
});

app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});