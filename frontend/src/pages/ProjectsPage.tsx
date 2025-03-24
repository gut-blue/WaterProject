import CookieConsent from 'react-cookie-consent';
import CategoryFilter from '../components/CategoryFilter';
import Fingerprint from '../components/Fingerprint';
import ProjectList from '../components/ProjectList';
import WelcomeBand from '../components/WelcomeBand';
import { useState } from 'react';
import CartSummary from '../components/CartSummary';

function ProjectsPage() {
  const [selectedCategories, setSelectedCategories] = useState<string[]>([]);

  return (
    <div className="container mt-4">
      <div className="row bg-primary text-white">
        <CartSummary />
        <WelcomeBand />
      </div>
      <div className="row">
        <div className="col-md-3">
          <CategoryFilter
            selectedCategories={selectedCategories}
            setSelectedCategories={setSelectedCategories}
          />
        </div>
        <div className="col-md-9">
          <ProjectList selectedCategories={selectedCategories} />
          <CookieConsent>This website uses cookies to enhance the user experience.</CookieConsent>
          <Fingerprint />
        </div>
      </div>
    </div>
  );
}

export default ProjectsPage;
