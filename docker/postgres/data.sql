INSERT INTO role (role_name) VALUES ('admin');
INSERT INTO role (role_name) VALUES ('user');

INSERT INTO account (username, password, email, created_on, last_login) VALUES ('Shaterinew', 'mohJ3enieng', 'MatildaLLamson@teleworm.us', now(), now());
INSERT INTO account (username, password, email, created_on, last_login) VALUES ('Pathoultat', 'PaiBie1su6oo', 'RichardLBrown@dayrep.com', now(), null);
INSERT INTO account (username, password, email, created_on, last_login) VALUES ('Farands89', 'phai8ih6Eer', 'AlanRMiller@dayrep.com', now(), null);
INSERT INTO account (username, password, email, created_on, last_login) VALUES ('Befordow1974', 'Chae7xeTh', 'BenjaminGHolman@jourrapide.com', now(), null);

INSERT INTO account_role(user_id, role_id, grant_date) VALUES (1, 1, now());
INSERT INTO account_role(user_id, role_id, grant_date) VALUES (1, 2, now());
INSERT INTO account_role(user_id, role_id, grant_date) VALUES (2, 2, now());
INSERT INTO account_role(user_id, role_id, grant_date) VALUES (3, 1, now());
INSERT INTO account_role(user_id, role_id, grant_date) VALUES (3, 2, now());
INSERT INTO account_role(user_id, role_id, grant_date) VALUES (4, 2, now());