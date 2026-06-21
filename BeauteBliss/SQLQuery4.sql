UPDATE Products
SET Category = 'Skin Care'
WHERE ProductName = 'Facial Cleanser';

UPDATE Products
SET Category = 'Hair Care'
WHERE ProductName = 'Hair Serum';

UPDATE Products
SET Category = 'Skin Care'
WHERE ProductName = 'Body Lotion';

UPDATE Products
SET Category = 'Hair Care'
WHERE ProductName = 'Hair Oil';

INSERT INTO Products
(ProductName, Brand, Price, Quantity, Category)

VALUES

('Facial Cleanser', 'Cetaphil', 35, 20, 'Skin Care'),

('Body Lotion', 'Vaseline', 25, 30, 'Skin Care'),

('Hair Serum', 'Mise En Scene', 50, 15, 'Hair Care'),

('Hair Oil', 'L Oreal', 45, 10, 'Hair Care');