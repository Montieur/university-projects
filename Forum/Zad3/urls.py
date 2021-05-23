from django.contrib import admin
from django.urls import path, include
from Forum import views

urlpatterns = [
    path('admin/', admin.site.urls, name='admin'),
    path('', views.homepage, name='homepage'),
    path('edit/<int:replyId>', views.editreply, name='editreply'),
    path('editThread/<int:threadId>', views.editthread, name='editthread'),
    path('accounts/', include('django.contrib.auth.urls')),
    path('accounts/register/', views.register, name='registration'),
    path('<str:sectionName>/', views.sectionpage, name='sectionpage'),
    path('<str:sectionName>/<int:threadId>', views.threadpage, name='threadpage'),
    path('<str:sectionName>/newthread', views.makethreadpage, name='newthread'),
    

]
