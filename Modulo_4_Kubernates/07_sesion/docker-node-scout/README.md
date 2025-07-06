# Clase 7: 
Servicio de docker scout

# Fecha: 
01/07/2025

# Objetivos
    - docker scout (Permite analizar las vulnerabilidades)
    - creación de tags de la imagen
    - Versionamientos MAJOR.MINOR.PATCH
    - logueo en docker con usuario y contraseña para controlado de versionamiento
    - docker compose se basa en registros 
    - tag semanticos
    - subir a docker hub
    - Creación de servicios 

    
# Comandos utilizados

    Git comit –m "Clase7" 
    docker swarm init --advertis e-addr 127.0.0.1 
    docker swarm init    
    docker swarm leave –force 
    docker swarm init 
    docker swarm join-token manager 
    docker service create --name monitor --mode global alpine:latest 127.0.0.1  
    docker node ls -q 
    docker node update --label-add tipo=frontend $(docker node ls -q) 
    docker service create --name webfront ++contraint "node.labels.tipo == frontend --replicas 2 p 8085:80 httpd:alpine 