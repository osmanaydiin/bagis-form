--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 14.0

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: veritabanim1; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE veritabanim1 WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';


ALTER DATABASE veritabanim1 OWNER TO postgres;

\connect veritabanim1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: adresara(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.adresara(adresno1 integer) RETURNS TABLE(adresi integer, sehri character varying, bolgesi character varying, ulkesi character varying, adresinturu character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT "adresno","sehir" , "bolge", "ulke", "adresturu" FROM "adres"
                 WHERE "adresno" = adresno1;
END;
$$;


ALTER FUNCTION public.adresara(adresno1 integer) OWNER TO postgres;

--
-- Name: bagisara(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.bagisara(bagisno1 integer) RETURNS TABLE(bagisnosu integer, kisinosu integer, bagisturu character varying, ulkesi character varying, miktari money)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT "bagis"."bagisno","bagis"."kisino" , "bagis"."bagistur","adres"."ulke","bagis"."miktar" FROM "bagis"
                INNER JOIN "adres" ON "bagis"."adresno" = "adres"."adresno" 
                WHERE "bagisno" = bagisno1;
END;
$$;


ALTER FUNCTION public.bagisara(bagisno1 integer) OWNER TO postgres;

--
-- Name: callcentersay(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.callcentersay() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

BEGIN
    IF ((SELECT COUNT(*) FROM "callcenter")>4)
    THEN
            RAISE EXCEPTION 'EN FAZLA CALL CENTER CALISANINA ULASILDI';
    END IF;
    RETURN NEW;

end;
$$;


ALTER FUNCTION public.callcentersay() OWNER TO postgres;

--
-- Name: deposay(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.deposay() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

BEGIN
    IF ((SELECT COUNT(*) FROM "depo")>4)
    THEN
            RAISE EXCEPTION 'EN FAZLA DEPO CALISANINA ULASILDI';
    END IF;
    RETURN NEW;

end;
$$;


ALTER FUNCTION public.deposay() OWNER TO postgres;

--
-- Name: detaylibagisciara(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.detaylibagisciara(kisino1 integer) RETURNS TABLE(kisinosu integer, bagisnosu integer, kisiadi character varying, kisisoyadi character varying, bagisturu character varying, miktari money)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT "kisi"."kisino", "bagis"."bagisno", "kisi"."kisiad", "kisi"."kisisoyad", "bagisci"."bagistur", "bagis"."miktar" FROM "bagisci"
                    INNER JOIN "bagis" ON "bagisci"."kisino" = "bagis"."kisino"
                    INNER JOIN "kisi" ON "bagisci"."kisino" = "kisi"."kisino" 
                    WHERE "bagisci"."kisino" = kisino1 ;
END;
$$;


ALTER FUNCTION public.detaylibagisciara(kisino1 integer) OWNER TO postgres;

--
-- Name: hizmetlisay(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.hizmetlisay() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

BEGIN
    IF ((SELECT COUNT(*) FROM "hizmetli")>4)
    THEN
            RAISE EXCEPTION 'EN FAZLA HIZMETLI CALISANINA ULASILDI';
    END IF;
    RETURN NEW;

end;
$$;


ALTER FUNCTION public.hizmetlisay() OWNER TO postgres;

--
-- Name: kisiara(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.kisiara(kisino1 integer) RETURNS TABLE(kisinosu integer, kisiadi character varying, kisisoyadi character varying, kisituru character varying, sehri character varying, bolgesi character varying, ulkesi character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT "kisi"."kisino" , "kisi"."kisiad", "kisi"."kisisoyad", "kisi"."kisitur", "adres"."sehir", "adres"."bolge", "adres"."ulke" FROM "kisi"
                INNER JOIN "adres" ON "kisi"."adresno" = "adres"."adresno"
                WHERE "kisino" = kisino1;
END;
$$;


ALTER FUNCTION public.kisiara(kisino1 integer) OWNER TO postgres;

--
-- Name: mudurluksay(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.mudurluksay() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

BEGIN
    IF ((SELECT COUNT(*) FROM "mudurluk")>4)
    THEN
            RAISE EXCEPTION 'EN FAZLA MUDUR CALISANINA ULASILDI';
    END IF;
    RETURN NEW;

end;
$$;


ALTER FUNCTION public.mudurluksay() OWNER TO postgres;

--
-- Name: projesay(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.projesay() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
DECLARE
    satirsayisi INTEGER;
    sorgu TEXT;
BEGIN
    IF ((SELECT COUNT(*) FROM "proje")>3)
    THEN
            RAISE EXCEPTION 'EN FAZLA PROJE CALISANINA ULASILDI';
    END IF;
    RETURN NEW;

end;
$$;


ALTER FUNCTION public.projesay() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: adres; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.adres (
    adresno integer NOT NULL,
    sehir character varying(30),
    bolge character varying(30),
    ulke character varying(30) NOT NULL,
    adresturu character varying(30)
);


ALTER TABLE public.adres OWNER TO postgres;

--
-- Name: bagis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bagis (
    bagisno integer NOT NULL,
    kisino integer,
    adresno integer,
    miktar money NOT NULL,
    bagistur character varying(20) DEFAULT 'sadaka'::character varying
);


ALTER TABLE public.bagis OWNER TO postgres;

--
-- Name: bagisadres; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bagisadres (
    adresno integer NOT NULL,
    bagisno integer NOT NULL,
    bagistur character varying(30) DEFAULT 'sadaka'::character varying
);


ALTER TABLE public.bagisadres OWNER TO postgres;

--
-- Name: bagisci; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bagisci (
    kisino integer NOT NULL,
    bagistur character varying(30) DEFAULT 'sadaka'::character varying
);


ALTER TABLE public.bagisci OWNER TO postgres;

--
-- Name: bagisciadres; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bagisciadres (
    adresno integer NOT NULL,
    kisino integer NOT NULL
);


ALTER TABLE public.bagisciadres OWNER TO postgres;

--
-- Name: kisi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kisi (
    kisino integer NOT NULL,
    kisiad character varying(30) NOT NULL,
    kisisoyad character varying(30) NOT NULL,
    kisitur character varying(30) NOT NULL,
    iletisimno integer,
    adresno integer
);


ALTER TABLE public.kisi OWNER TO postgres;

--
-- Name: bagiscilistele; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.bagiscilistele AS
 SELECT kisi.kisino,
    bagisciadres.adresno,
    kisi.kisiad,
    kisi.kisisoyad,
    adres.sehir,
    adres.bolge,
    adres.ulke
   FROM (((public.adres
     JOIN public.kisi ON ((adres.adresno = kisi.adresno)))
     JOIN public.bagisciadres ON ((adres.adresno = bagisciadres.adresno)))
     JOIN public.bagisci ON ((kisi.kisino = bagisci.kisino)));


ALTER TABLE public.bagiscilistele OWNER TO postgres;

--
-- Name: bagislistele; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.bagislistele AS
 SELECT bagis.bagisno,
    adres.adresno,
    adres.ulke,
    bagisadres.bagistur,
    bagis.miktar,
    bagis.kisino
   FROM ((public.adres
     JOIN public.bagisadres ON ((adres.adresno = bagisadres.adresno)))
     JOIN public.bagis ON ((adres.adresno = bagis.adresno)));


ALTER TABLE public.bagislistele OWNER TO postgres;

--
-- Name: bagislistesi; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.bagislistesi AS
 SELECT bagis.bagisno,
    bagis.miktar,
    adres.ulke,
    bagisadres.bagistur,
    bagis.kisino,
    bagis.adresno
   FROM ((public.adres
     JOIN public.bagis ON ((adres.adresno = bagis.adresno)))
     JOIN public.bagisadres ON ((adres.adresno = bagisadres.adresno)));


ALTER TABLE public.bagislistesi OWNER TO postgres;

--
-- Name: callcenter; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.callcenter (
    kisino integer NOT NULL,
    gorev character varying(40) NOT NULL,
    maas money DEFAULT 2.750
);


ALTER TABLE public.callcenter OWNER TO postgres;

--
-- Name: depo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.depo (
    kisino integer NOT NULL,
    gorev character varying(40) NOT NULL,
    maas money DEFAULT 2.750
);


ALTER TABLE public.depo OWNER TO postgres;

--
-- Name: hizmetli; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.hizmetli (
    kisino integer NOT NULL,
    gorev character varying(40) NOT NULL,
    maas money DEFAULT 2.750
);


ALTER TABLE public.hizmetli OWNER TO postgres;

--
-- Name: kurban; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kurban (
    bagisno integer NOT NULL,
    kisino integer NOT NULL,
    iletisimno integer
);


ALTER TABLE public.kurban OWNER TO postgres;

--
-- Name: mudurluk; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.mudurluk (
    kisino integer NOT NULL,
    gorev character varying(40) NOT NULL,
    maas money DEFAULT 2.750
);


ALTER TABLE public.mudurluk OWNER TO postgres;

--
-- Name: personel; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.personel (
    kisino integer NOT NULL,
    calismaalani character varying(15) NOT NULL
);


ALTER TABLE public.personel OWNER TO postgres;

--
-- Name: personeladres; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.personeladres (
    adresno integer NOT NULL,
    kisino integer NOT NULL
);


ALTER TABLE public.personeladres OWNER TO postgres;

--
-- Name: proje; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.proje (
    kisino integer NOT NULL,
    gorev character varying(40) NOT NULL,
    maas money DEFAULT 2.750
);


ALTER TABLE public.proje OWNER TO postgres;

--
-- Name: sadaka; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sadaka (
    bagisno integer NOT NULL,
    kisino integer NOT NULL,
    iletisimno integer
);


ALTER TABLE public.sadaka OWNER TO postgres;

--
-- Name: sukuyusu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sukuyusu (
    bagisno integer NOT NULL,
    kisino integer NOT NULL,
    iletisimno integer
);


ALTER TABLE public.sukuyusu OWNER TO postgres;

--
-- Name: yetimhamiligi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.yetimhamiligi (
    bagisno integer NOT NULL,
    kisino integer NOT NULL,
    iletisimno integer
);


ALTER TABLE public.yetimhamiligi OWNER TO postgres;

--
-- Data for Name: adres; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.adres (adresno, sehir, bolge, ulke, adresturu) VALUES
	(2, ' ', ' ', 'sadas', 'bagis adresi'),
	(3, 'asd', 'asd', 'sad', 'bagisci adresi'),
	(4, ' ', ' ', 'sadsa', 'bagis adres'),
	(7, ' ', ' ', 'endonezya', 'bagis adresi');


--
-- Data for Name: bagis; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.bagis (bagisno, kisino, adresno, miktar, bagistur) VALUES
	(1, 1, 2, '?900,00', 'KURBAN'),
	(2, 2, 4, '?900,00', 'KURBAN'),
	(4, 3, 7, '?1.500,00', 'SU KUYUSU');


--
-- Data for Name: bagisadres; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.bagisadres (adresno, bagisno, bagistur) VALUES
	(2, 1, 'KURBAN'),
	(4, 2, 'KURBAN'),
	(7, 4, 'SU KUYUSU');


--
-- Data for Name: bagisci; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.bagisci (kisino, bagistur) VALUES
	(2, 'KURBAN');


--
-- Data for Name: bagisciadres; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.bagisciadres (adresno, kisino) VALUES
	(3, 2);


--
-- Data for Name: callcenter; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: depo; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: hizmetli; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: kisi; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.kisi (kisino, kisiad, kisisoyad, kisitur, iletisimno, adresno) VALUES
	(2, 'ahmet', 'sakız', 'bagisci', 2, 3);


--
-- Data for Name: kurban; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.kurban (bagisno, kisino, iletisimno) VALUES
	(1, 1, 1),
	(2, 2, 0);


--
-- Data for Name: mudurluk; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: personel; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: personeladres; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: proje; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: sadaka; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: sukuyusu; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.sukuyusu (bagisno, kisino, iletisimno) VALUES
	(4, 3, 3);


--
-- Data for Name: yetimhamiligi; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Name: adres adrespk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.adres
    ADD CONSTRAINT adrespk PRIMARY KEY (adresno);


--
-- Name: bagisadres bagisadrespk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bagisadres
    ADD CONSTRAINT bagisadrespk PRIMARY KEY (adresno);


--
-- Name: bagisciadres bagisciadrespk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bagisciadres
    ADD CONSTRAINT bagisciadrespk PRIMARY KEY (adresno);


--
-- Name: bagisci bagiscipk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bagisci
    ADD CONSTRAINT bagiscipk PRIMARY KEY (kisino);


--
-- Name: bagis bagispk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bagis
    ADD CONSTRAINT bagispk PRIMARY KEY (bagisno);


--
-- Name: callcenter callcenterpk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.callcenter
    ADD CONSTRAINT callcenterpk PRIMARY KEY (kisino);


--
-- Name: depo depopk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.depo
    ADD CONSTRAINT depopk PRIMARY KEY (kisino);


--
-- Name: hizmetli hizmetlipk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hizmetli
    ADD CONSTRAINT hizmetlipk PRIMARY KEY (kisino);


--
-- Name: kisi kisipk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi
    ADD CONSTRAINT kisipk PRIMARY KEY (kisino);


--
-- Name: kurban kurbanpk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kurban
    ADD CONSTRAINT kurbanpk PRIMARY KEY (bagisno);


--
-- Name: mudurluk mudurlukpk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.mudurluk
    ADD CONSTRAINT mudurlukpk PRIMARY KEY (kisino);


--
-- Name: personeladres personeladrespk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personeladres
    ADD CONSTRAINT personeladrespk PRIMARY KEY (adresno);


--
-- Name: personel personelpk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personel
    ADD CONSTRAINT personelpk PRIMARY KEY (kisino);


--
-- Name: proje projepk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proje
    ADD CONSTRAINT projepk PRIMARY KEY (kisino);


--
-- Name: sadaka sadakapk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sadaka
    ADD CONSTRAINT sadakapk PRIMARY KEY (bagisno);


--
-- Name: sukuyusu sukuyusupk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sukuyusu
    ADD CONSTRAINT sukuyusupk PRIMARY KEY (bagisno);


--
-- Name: yetimhamiligi yetimhamiligipk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.yetimhamiligi
    ADD CONSTRAINT yetimhamiligipk PRIMARY KEY (bagisno);


--
-- Name: callcenter callcentersaytrigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER callcentersaytrigger AFTER INSERT OR UPDATE ON public.callcenter FOR EACH ROW EXECUTE FUNCTION public.callcentersay();


--
-- Name: depo deposaytrigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER deposaytrigger AFTER INSERT OR UPDATE ON public.depo FOR EACH ROW EXECUTE FUNCTION public.deposay();


--
-- Name: hizmetli hizmetlisaytrigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER hizmetlisaytrigger AFTER INSERT OR UPDATE ON public.hizmetli FOR EACH ROW EXECUTE FUNCTION public.hizmetlisay();


--
-- Name: mudurluk mudurluksaytrigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER mudurluksaytrigger AFTER INSERT OR UPDATE ON public.mudurluk FOR EACH ROW EXECUTE FUNCTION public.mudurluksay();


--
-- Name: proje projesaytrigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER projesaytrigger BEFORE INSERT OR UPDATE ON public.proje FOR EACH ROW EXECUTE FUNCTION public.projesay();


--
-- Name: bagisadres bagisadresfk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bagisadres
    ADD CONSTRAINT bagisadresfk FOREIGN KEY (adresno) REFERENCES public.adres(adresno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: bagisciadres bagisciadresfk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bagisciadres
    ADD CONSTRAINT bagisciadresfk FOREIGN KEY (adresno) REFERENCES public.adres(adresno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: bagisci bagiscifk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bagisci
    ADD CONSTRAINT bagiscifk FOREIGN KEY (kisino) REFERENCES public.kisi(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: bagis bagisfk2; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bagis
    ADD CONSTRAINT bagisfk2 FOREIGN KEY (adresno) REFERENCES public.adres(adresno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: callcenter callCenterfk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.callcenter
    ADD CONSTRAINT "callCenterfk" FOREIGN KEY (kisino) REFERENCES public.personel(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: depo depofk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.depo
    ADD CONSTRAINT depofk FOREIGN KEY (kisino) REFERENCES public.personel(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: hizmetli hizmetlifk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hizmetli
    ADD CONSTRAINT hizmetlifk FOREIGN KEY (kisino) REFERENCES public.personel(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kisi kisifk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi
    ADD CONSTRAINT kisifk FOREIGN KEY (adresno) REFERENCES public.adres(adresno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kurban kurbanfk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kurban
    ADD CONSTRAINT kurbanfk FOREIGN KEY (bagisno) REFERENCES public.bagis(bagisno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: mudurluk mudurlukfk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.mudurluk
    ADD CONSTRAINT mudurlukfk FOREIGN KEY (kisino) REFERENCES public.personel(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: personeladres personeladresfk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personeladres
    ADD CONSTRAINT personeladresfk FOREIGN KEY (adresno) REFERENCES public.adres(adresno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: personel personelfk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personel
    ADD CONSTRAINT personelfk FOREIGN KEY (kisino) REFERENCES public.kisi(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: proje projefk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proje
    ADD CONSTRAINT projefk FOREIGN KEY (kisino) REFERENCES public.personel(kisino) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: sadaka sadakafk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sadaka
    ADD CONSTRAINT sadakafk FOREIGN KEY (bagisno) REFERENCES public.bagis(bagisno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: sukuyusu sukuyusufk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sukuyusu
    ADD CONSTRAINT sukuyusufk FOREIGN KEY (bagisno) REFERENCES public.bagis(bagisno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: yetimhamiligi yetimhamiligifk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.yetimhamiligi
    ADD CONSTRAINT yetimhamiligifk FOREIGN KEY (bagisno) REFERENCES public.bagis(bagisno) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

