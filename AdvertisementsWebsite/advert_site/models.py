from django.db import models

# Create your models here.

class Advertisement(models.Model):
    id = models.AutoField(primary_key=True)
    brandName = models.CharField(max_length=32)
    modelName = models.CharField(max_length=32)
    yearOfProduction = models.CharField(max_length=8)
    mileage = models.CharField(max_length=64)
    description = models.TextField()
    price = models.CharField(max_length=32)
    phone = models.CharField(max_length=16)
    mail = models.CharField(max_length=256)
    
