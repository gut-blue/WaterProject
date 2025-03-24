import React from 'react';

const PrivacyPolicy: React.FC = () => {
  return (
    <div style={{ maxWidth: '800px', margin: 'auto', padding: '20px', fontFamily: 'Arial, sans-serif' }}>
      <h1 style={{ fontSize: '24px', fontWeight: 'bold', marginBottom: '10px' }}>Privacy Policy</h1>
      <p style={{ marginBottom: '10px' }}>Effective Date: [Insert Date]</p>

      <p>
        Welcome to Water Project. Your privacy is important to us. This Privacy Policy explains how we collect, use, disclose, and protect your personal information when you
        use our website and services.
      </p>

      <h2 style={{ fontSize: '20px', fontWeight: 'bold', marginTop: '20px' }}>1. Information We Collect</h2>
      <ul>
        <li>Personal Information: When you donate, register, or contact us, we may collect your name, email address, phone number, and payment details.</li>
        <li>Non-Personal Information: We may collect data such as browser type, IP address, and usage patterns to improve our services.</li>
        <li>Cookies: We use cookies to enhance user experience and analyze website traffic.</li>
      </ul>

      <h2 style={{ fontSize: '20px', fontWeight: 'bold', marginTop: '20px' }}>2. How We Use Your Information</h2>
      <ul>
        <li>To process donations and provide updates on our projects.</li>
        <li>To improve our website, services, and user experience.</li>
        <li>To comply with legal obligations and protect against fraudulent activity.</li>
      </ul>

      <h2 style={{ fontSize: '20px', fontWeight: 'bold', marginTop: '20px' }}>3. How We Share Your Information</h2>
      <ul>
        <li>We do not sell or rent your personal data.</li>
        <li>We may share information with service providers who assist in processing donations and running our platform.</li>
        <li>We may disclose information if required by law or to protect our rights.</li>
      </ul>

      <h2 style={{ fontSize: '20px', fontWeight: 'bold', marginTop: '20px' }}>4. Data Security</h2>
      <p>We implement security measures to protect your personal data. However, no method of transmission over the internet is 100% secure.</p>

      <h2 style={{ fontSize: '20px', fontWeight: 'bold', marginTop: '20px' }}>5. Your Rights</h2>
      <ul>
        <li>You can request access, correction, or deletion of your personal data.</li>
        <li>You may opt out of communications by following the unsubscribe instructions.</li>
      </ul>

      <h2 style={{ fontSize: '20px', fontWeight: 'bold', marginTop: '20px' }}>6. Third-Party Links</h2>
      <p>Our website may contain links to third-party websites. We are not responsible for their privacy practices.</p>

      <h2 style={{ fontSize: '20px', fontWeight: 'bold', marginTop: '20px' }}>7. Updates to This Policy</h2>
      <p>We may update this policy from time to time. Changes will be posted on this page.</p>

      <h2 style={{ fontSize: '20px', fontWeight: 'bold', marginTop: '20px' }}>8. Contact Us</h2>
      <p>
        If you have any questions about this Privacy Policy, please contact us at <strong>[Insert Contact Email]</strong>.
      </p>
    </div>
  );
};

export default PrivacyPolicy;
