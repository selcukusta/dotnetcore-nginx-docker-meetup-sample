FROM nginx:1.13.6
COPY sampleapp.conf /etc/nginx/conf.d/sampleapp.conf
COPY nginx.conf /etc/nginx/nginx.conf
RUN [ "mv", "/etc/nginx/conf.d/default.conf", "/etc/nginx/conf.d/default.conf_" ]