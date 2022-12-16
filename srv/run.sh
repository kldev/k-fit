export VERSION="$(git rev-parse --short HEAD)"


docker-compose -f docker-compose.yml -f docker-compose.api.yml up 