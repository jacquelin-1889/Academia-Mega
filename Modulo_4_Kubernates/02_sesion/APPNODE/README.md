# Clase 2: 
Creación de primera app / imagen con docker

# Fecha: 
24/06/2025

# Objetivos
    - Aprender a crear una aplicación en docker y ejecutarla


# Propietario
    Elvia Jacquelin Gonzalez Macias
    
# Comandos
Construir la imagen 

 

Inicializas node: 

    npm init –y 

Instalas express: 

    npm install express 

Corre la aplicación en local con el puerto http://localhost:3000 

    npm start 

Creas la aplicación el nombre que quieras y la versiópn que quieras 

    docker build -t primeraappdocker:1.0 . 

 

Si es necesario aplicas, si no lo pide nop 

    docker scout quickview 

Corres docker: 

    start docker 

 
Prendes la aplicación: 

    docker run -d --name contendorapp -p 3000:3000 primeraappdocker:1.0 