FROM postgres:12.1

COPY ./create_db.sh /docker-entrypoint-initdb.d/20-create_db.sh
COPY schema.sql /schema.sql
COPY data.sql /data.sql

RUN chmod +x /docker-entrypoint-initdb.d/20-create_db.sh
# no need to change entrypoint - postgres image runs all scripts from /docker-entrypoint-initdb.d directory