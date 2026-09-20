const COVERS = [
  'images/photos/laptop.jpg',
  'images/photos/team.jpg',
  'images/photos/ecommerce.jpg',
  'images/photos/workspace.jpg',
];

export function blogCover(id: number): string {
  return COVERS[Math.abs(id) % COVERS.length];
}
