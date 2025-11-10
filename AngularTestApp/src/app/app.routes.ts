import { Routes } from '@angular/router';
import { Home } from './presentation/views/home/home';
import { Features } from './presentation/views/features/features';

export const routes: Routes = [
    { path: 'home', component: Home},
    { path: 'features', component: Features },
    {
        path: '',
        redirectTo: 'home',
        pathMatch: 'full'
    },
    {
        path: '**',
        redirectTo: 'home',
        pathMatch: 'full'
    }
];
