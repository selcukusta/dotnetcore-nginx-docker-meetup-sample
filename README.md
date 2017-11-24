# .NET Core Web Application & Nginx & Docker
**@Xamarin İstanbul Meetup**
***
![logo](https://raw.githubusercontent.com/selcukusta/docker-compose-netcore-app/master/banner.png)
***
*.NET Core ile geliştirilen web uygulamasının Nginx arkasından servis edilmesi üzerine örnek uygulamadır.*

> **Meetup'taki örnekte olduğu gibi uygulamaların Azure üzerinden servis edilmesi için yapılması gerekenler;**

> - Azure üzerinden "Template Deployment" ile yeni bir servis oluşturma isteği yapılır.
> - Açılan penceredeki "Select Template" alanından "docker-simple-on-ubuntu" seçeneği seçilir.
> - Servis için gerekli alanlar doldurulur.
> - Servis oluşturulduktan sonra VM'e Putty - ya da benzeri - bir uygulama ile bağlanılır.
> - "nano docker-compose.yml" komutu ile boş bir docker compose konfigürasyon dosyası oluşturulur, repo içerisindeki dosyanın içeriği bu dosyaya aktarılır.
> - "docker-compose up -d" komutu ile uygulamalar çalıştırılır.
