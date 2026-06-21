SELECT * FROM ServiceList
ALTER TABLE ServiceList
ADD ImagePath NVARCHAR(255);

UPDATE ServiceList
SET ImagePath = 'Images\Brightening Facial.jpg'
WHERE ServiceName = 'Brightening Facial';

UPDATE ServiceList
SET ImagePath = 'Images\acne treatment.jpg'
WHERE ServiceName = 'Acne Treatment Facial';

UPDATE ServiceList
SET ImagePath = 'Images\hair treatment.jpg'
WHERE ServiceName = 'Hair Spa Treatment';

UPDATE ServiceList
SET ImagePath = 'Images\foot massage.jpg'
WHERE ServiceName = 'Foot Massage';

UPDATE ServiceList
SET ImagePath = 'Images\french tip manicure.jpg'
WHERE ServiceName = 'French Tip Manicure';