USE DbPratice

GO

CREATE PROC LOAIXE_Group4Search
@Ma int = NULL,
@LoaiXe_Ten nvarchar(50) = NULL,
@LoaiXe_Hang nvarchar(50) = NULL,
@LoaiXe_DinhMucNhienLieu float = NULL,
@LoaiXe_NamSX int = NULL,
@LoaiXe_LoaiNhienLieu varchar(1) = NULL
AS
BEGIN
	SELECT * FROM LoaiXe
	WHERE
	(@Ma is NULL or LoaiXe.Ma = @Ma) and
	(@LoaiXe_Ten is NULL or LoaiXe.LoaiXe_Ten = '' or LoaiXe.LoaiXe_Ten like '%' + @LoaiXe_Ten + '%') and
	(@LoaiXe_Hang is NULL or LoaiXe.LoaiXe_Hang = '' or LoaiXe.LoaiXe_Hang like '%' + @LoaiXe_Hang + '%') and
	(@LoaiXe_DinhMucNhienLieu is NULL or LoaiXe.LoaiXe_DinhMucNhienLieu = @LoaiXe_DinhMucNhienLieu) and
	(@LoaiXe_NamSX is NULL or LoaiXe.LoaiXe_NamSX = @LoaiXe_NamSX) and
	(@LoaiXe_LoaiNhienLieu is NULL or @LoaiXe_LoaiNhienLieu = '' or LoaiXe.LoaiXe_LoaiNhienLieu like @LoaiXe_LoaiNhienLieu) and
	(LoaiXe.LoaiXe_TrangThai != 'X')
END
GO
CREATE PROC LOAIXE_Group4SearchById
@Ma int = NULL
AS
BEGIN
	SELECT * FROM LoaiXe
	WHERE LoaiXe.Ma = @Ma
END
