CREATE TABLE tugas(
	id SERIAL PRIMARY KEY,
	daftar_tugas VARCHAR(100) NOT NULL
);

CREATE TABLE tugasbaru(
	id SERIAL PRIMARY KEY
	judul VARCHAR (100) NOT NULL
	deskripsi VARCHAR (100) NOT NULL
	deadline VARCHAR (100) NOT NULL
);
INSERT INTO tugas(daftar_tugas) VALUES
('Analisa Perancangan Sistem')
('Riset Operasi')
('Analitik Visualisasi Data')

INSERT INTO tugasbaru(judul, deskripsi, deadline) VALUES
