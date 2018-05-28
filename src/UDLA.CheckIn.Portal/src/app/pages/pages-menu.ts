import { NbMenuItem } from '@nebular/theme';

export const MENU_ITEMS: NbMenuItem[] = [
  {
    title: 'Inicio',
    icon: 'nb-home',
    link: '/pages/dashboard',
    home: true,
  },
  {
    title: 'Formularios',
    icon: 'nb-compose',
    children: [
      {
        title: 'Facultades',
        link: '/pages/forms/facultades',
      },
      {
        title: 'Profesores',
        link: '/pages/forms/profesores',
      },
    ],
  },
  {
    title: 'Tablas',
    icon: 'nb-tables',
    children: [
      {
        title: 'Facultades',
        link: '/pages/tables/facultades',
      },
      {
        title: 'Profesores',
        link: '/pages/tables/profesores',
      },
      {
        title: 'Ingresos',
        link: '/pages/tables/entries'
      }
    ],
  }
];
