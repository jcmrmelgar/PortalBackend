
**PortalBackend**

[https://github.com/jcmrmelgar/PortalBackend](https://github.com/jcmrmelgar/PortalBackend)

En piloto para el BackEnd se eligio el modulo de reservas enfocado e la operativa que debe de realizar el portal segun el diseño planteado que es crear una reserva (CRUD) y el almacen de datos que debe de realizar la operativa lo realiza en memoria. La propuesta cubre lo siguiente:

**Control de versiones y despliegue automatico:**

Git

GithubActions

Docker y docker hub

```docker
docker build -t portal_backend_api:latest .
```

```docker
docker run -it --rm -p 8080:80 portal_backend_api
```

[**http://localhost:8080/cotizacion**](http://localhost:8080/cotizacion)

![Screen Shot 2022-01-24 at 10.09.11.png](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/f57d6091-6057-4898-8fa2-49a0150307ae/Screen_Shot_2022-01-24_at_10.09.11.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220124%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220124T170330Z&X-Amz-Expires=86400&X-Amz-Signature=25add3ed5e23bc448d6352796bf64dc2836155cbe63b5185ff76d1b2e7015a42&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Screen%2520Shot%25202022-01-24%2520at%252010.09.11.png%22&x-id=GetObject)

[**https://hub.docker.com/repository/docker/jcmrmelgar/portal_backend_api**](https://hub.docker.com/repository/docker/jcmrmelgar/portal_backend_api)

![Screen Shot 2022-01-24 at 10.40.05.png](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/7165bc6a-c33a-4e99-9e2b-2c742e6f0a13/Screen_Shot_2022-01-24_at_10.40.05.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220124%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220124T170405Z&X-Amz-Expires=86400&X-Amz-Signature=8255bf41d576d582d3f15fdc5ae24d18e9bd5af1d37a679f0b4a8d7bb0faf16c&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Screen%2520Shot%25202022-01-24%2520at%252010.40.05.png%22&x-id=GetObject)

**Stack**

C#

Dependency Injection para favorecer un grado de acoplamiento bajo, pero sin sacrificar la cohesión y  Data Transfer Object DTO debido a la comunicación entre procesos se realiza generalmente mediante interfaces remotas APIm para la reduccion del numero de llamadas

**Documentacion**:

Swagger

![Screen Shot 2022-01-24 at 10.01.28.png](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/36b24ffe-db8e-4b0c-b261-6d73e582bf2f/Screen_Shot_2022-01-24_at_10.01.28.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220124%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220124T170434Z&X-Amz-Expires=86400&X-Amz-Signature=bc7f60ebe7957470a223ced789b3e01892e0f5e433d1fcf58439ca0e20aec026&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Screen%2520Shot%25202022-01-24%2520at%252010.01.28.png%22&x-id=GetObject)

**despliegue**:

![Screen Shot 2022-01-24 at 10.53.28.png](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/f6d9fd71-293d-442a-9998-c8e6d6a56f50/Screen_Shot_2022-01-24_at_10.53.28.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220124%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220124T170452Z&X-Amz-Expires=86400&X-Amz-Signature=a17300cf98a8c8a5f06635fec2a1c6d5e65eecb618f441e30bb44c44fbc9575d&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Screen%2520Shot%25202022-01-24%2520at%252010.53.28.png%22&x-id=GetObject)

![Screen Shot 2022-01-24 at 10.54.11.png](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/93573947-8325-4ef5-afa3-632479151f3d/Screen_Shot_2022-01-24_at_10.54.11.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220124%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220124T170509Z&X-Amz-Expires=86400&X-Amz-Signature=9dd8503e211976198f08d7fdf7d1c02252d7f08a0a8e278549dbcb4ce7c948a7&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Screen%2520Shot%25202022-01-24%2520at%252010.54.11.png%22&x-id=GetObject)

![Screen Shot 2022-01-24 at 10.11.30.png](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/d3ea3ba4-4575-4f52-b5ef-d774140d75c0/Screen_Shot_2022-01-24_at_10.11.30.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220124%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220124T170528Z&X-Amz-Expires=86400&X-Amz-Signature=e55ea2a594f2219d11cc057e2df1cded564a9b7972c4370618e11844c44d200a&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Screen%2520Shot%25202022-01-24%2520at%252010.11.30.png%22&x-id=GetObject)

![Screen Shot 2022-01-24 at 10.20.18.png](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/1be6e969-352e-4bcb-b38c-265985d7c778/Screen_Shot_2022-01-24_at_10.20.18.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220124%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220124T170542Z&X-Amz-Expires=86400&X-Amz-Signature=02f8446165d2324be5d960198b36ec72e567ec88097b7639c7807fe71f3c9278&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Screen%2520Shot%25202022-01-24%2520at%252010.20.18.png%22&x-id=GetObject)

![Screen Shot 2022-01-24 at 10.21.13.png](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/2a1bb7e5-3c5d-4f60-8f3d-b711496d6ae2/Screen_Shot_2022-01-24_at_10.21.13.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20220124%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20220124T170558Z&X-Amz-Expires=86400&X-Amz-Signature=25fe12a18123175af46ad69c68ccb1cbf8c80f20af3a686edf5618974e0e9489&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Screen%2520Shot%25202022-01-24%2520at%252010.21.13.png%22&x-id=GetObject)
