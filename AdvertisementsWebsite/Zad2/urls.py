from django.contrib import admin
from django.urls import path
from advert_site import views

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', views.homepage, name='homepage'),
    path('home.html', views.homepage),
    path('advert/<int:advertId>', views.getAdvert, name='getAdvert'),
    path('add.html', views.newAdvert)
]
