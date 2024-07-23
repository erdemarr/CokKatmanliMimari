create proc sp_OgretmenEkle
(
	@Adi nvarchar(50),
	@SoyAdi nvarchar(50),
	@Bransi nvarchar(50)
)as
	Insert Ogretmenler Values(@Adi, @SoyAdi, @Bransi)
	go
create proc sp_OgrenciEkle
(
	@Adi nvarchar(50),
	@SoyAdi nvarchar(50),
	@No nvarchar(50),
	@OgretmenID int
)as
	Insert Ogrenciler Values(@OgretmenID, @Adi, @SoyAdi, @No)
	go
create proc sp_OgretmenleriCek
as
	Select * from Ogretmenler

	Select * from Ogretmenler
	Select * from Ogrenciler