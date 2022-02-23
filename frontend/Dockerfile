FROM node:14.17.0-alpine as build
WORKDIR /app
COPY . .
RUN npm install
RUN npm run build --prod

FROM nginx:alpine AS ngi
COPY --from=build /app/dist/BankingDemo /usr/share/nginx/html
COPY /nginx.conf  /etc/nginx/conf.d/default.conf
EXPOSE 8050
